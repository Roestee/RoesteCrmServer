using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.CreateRole;

public sealed class CreateRoleCommandHandler(
    RoleManager<IdentityRole<Guid>> roleManager) : IRequestHandler<CreateRoleCommand, Result<IdentityRole<Guid>>>
{
    public async Task<Result<IdentityRole<Guid>>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        if (await roleManager.RoleExistsAsync(request.Name))
            return Result<IdentityRole<Guid>>.Failure("Bu rol zaten tanımlanmış!");

        var role = new IdentityRole<Guid>(request.Name);
        var result = await roleManager.CreateAsync(role);

        return result.Succeeded
            ? Result<IdentityRole<Guid>>.Succeed(role, "Rol başarıyla eklendi.")
            : Result<IdentityRole<Guid>>.Failure("Rol eklenirken hata oluştu!");
    }
}