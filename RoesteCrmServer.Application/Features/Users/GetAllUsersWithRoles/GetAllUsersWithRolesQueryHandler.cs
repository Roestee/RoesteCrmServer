using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.GetAllUsersWithRoles;

internal sealed class GetAllUsersWithRolesQueryHandler(
    UserManager<AppUser> userManager) : IRequestHandler<GetAllUsersWithRolesQuery, Result<List<GetAllUsersQueryResponse>>>
{
    public async Task<Result<List<GetAllUsersQueryResponse>>> Handle(GetAllUsersWithRolesQuery request, CancellationToken cancellationToken)
    {
        var users = await userManager.Users.ToListAsync(cancellationToken);
        var responses = users.Select(u => new GetAllUsersQueryResponse(
            u.Id
            ,u.FirstName
            ,u.LastName
            ,u.UserName?? ""
            ,u.Email?? ""
            ,u.PhoneNumber?? ""
            ,userManager.GetRolesAsync(u).Result.FirstOrDefault())
        ).ToList();

        return responses;
    }
}