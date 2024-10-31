using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.DeleteRoleById;

internal sealed class DeleteRoleByIdHandler(RoleManager<IdentityRole<Guid>> roleManager)
    : IRequestHandler<DeleteRoleByIdCommand, Result<IdentityRole<Guid>>>
{
    public async Task<Result<IdentityRole<Guid>>> Handle(DeleteRoleByIdCommand request,
        CancellationToken cancellationToken)
    {
        var role = await roleManager.FindByIdAsync(request.Id.ToString());
        if (role == null)
            return Result<IdentityRole<Guid>>.Failure("Rol bulunamadı!");

        var result = await roleManager.DeleteAsync(role);
        return result.Succeeded
            ? Result<IdentityRole<Guid>>.Succeed(role, "Rol başarıyla silindi!")
            : Result<IdentityRole<Guid>>.Failure("Rol silinirken hata oluştu!");
    }
}