using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.CreateUser;

public sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string Username,
    string Email,
    string? PhoneNumber,
    string Password,
    string Role) : IRequest<Result<CreateUserCommandResponse>>;