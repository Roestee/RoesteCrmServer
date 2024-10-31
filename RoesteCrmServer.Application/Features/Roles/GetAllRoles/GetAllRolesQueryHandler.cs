using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.GetAllRoles;

internal sealed class GetAllRolesQueryHandler(RoleManager<IdentityRole<Guid>> roleManager)
    : IRequestHandler<GetAllRolesQuery, Result<List<IdentityRole<Guid>>>>
{
    public async Task<Result<List<IdentityRole<Guid>>>> Handle(GetAllRolesQuery request,
        CancellationToken cancellationToken)
    {
        var roles = await roleManager.Roles.ToListAsync(cancellationToken);
        return roles;
    }
}