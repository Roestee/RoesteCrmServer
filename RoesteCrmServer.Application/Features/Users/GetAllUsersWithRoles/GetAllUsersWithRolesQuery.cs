using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Users.GetAllUsersWithRoles;

public sealed record GetAllUsersWithRolesQuery : IRequest<Result<List<GetAllUsersQueryResponse>>>;