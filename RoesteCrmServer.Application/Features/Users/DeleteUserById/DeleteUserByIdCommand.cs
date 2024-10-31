using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.DeleteUserById;

public sealed record DeleteUserByIdCommand(Guid Id): IRequest<Result<AppUser>>;