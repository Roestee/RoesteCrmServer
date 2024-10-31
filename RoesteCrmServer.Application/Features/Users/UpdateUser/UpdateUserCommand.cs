using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Users.UpdateUser;

public sealed record UpdateUserCommand(
    Guid Id,
    string FirstName,
    string LastName,
    string Username,
    string Email,
    string PhoneNumber,
    string Role): IRequest<Result<UpdateUserCommandResponse>>;