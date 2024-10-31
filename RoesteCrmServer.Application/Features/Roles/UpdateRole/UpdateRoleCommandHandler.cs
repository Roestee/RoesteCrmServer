using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.UpdateRole;

public sealed class UpdateRoleCommandHandler(RoleManager<IdentityRole<Guid>> roleManager)
    : IRequestHandler<UpdateRoleCommand, Result<IdentityRole<Guid>>>
{
    public async Task<Result<IdentityRole<Guid>>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await roleManager.FindByIdAsync(request.Id.ToString());
        if (role == null)
            return Result<IdentityRole<Guid>>.Failure("Rol bulunamadı!");

        var checkIsRoleNameExist = await roleManager.RoleExistsAsync(request.Name);
        if (checkIsRoleNameExist)
            return Result<IdentityRole<Guid>>.Failure("Bu rol ismi daha önce kullanılmış!");

        role.Name = request.Name;
        var result = await roleManager.UpdateAsync(role);
        return result.Succeeded
            ? Result<IdentityRole<Guid>>.Succeed(role, "Rol başarıyla güncellendi.")
            : Result<IdentityRole<Guid>>.Failure("Rol güncellenirken hata oluştu!");
    }
}