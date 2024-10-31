using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Users.DeleteUserByEmail;

public sealed record DeleteUserByEmailCommand(string Email): IRequest<Result<string>>;