using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.GetAllRoles;

public sealed record GetAllRolesQuery: IRequest<Result<List<IdentityRole<Guid>>>>;