using MediatR;
using Microsoft.AspNetCore.Identity;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Roles.DeleteRoleById;

public sealed record DeleteRoleByIdCommand(Guid Id): IRequest<Result<IdentityRole<Guid>>>;