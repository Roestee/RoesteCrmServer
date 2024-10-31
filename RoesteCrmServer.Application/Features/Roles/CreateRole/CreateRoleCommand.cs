using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.CreateRole;

public sealed record CreateRoleCommand(string Name): IRequest<Result<IdentityRole<Guid>>>;