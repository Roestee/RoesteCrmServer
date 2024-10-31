using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.UpdateRole;

public sealed record UpdateRoleCommand(Guid Id, string Name) : IRequest<Result<IdentityRole<Guid>>>;

