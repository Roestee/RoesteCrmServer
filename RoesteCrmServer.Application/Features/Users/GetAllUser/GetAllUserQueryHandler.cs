using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.GetAllUser;

internal sealed class GetAllUserQueryHandler(UserManager<AppUser> userManager) : IRequestHandler<GetAllUserQuery, Result<List<AppUser>>>
{
    public async Task<Result<List<AppUser>>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        var users = await userManager.Users
            .OrderBy(x=>x.FirstName)
            .ToListAsync(cancellationToken);
        
        return users;
    }
}