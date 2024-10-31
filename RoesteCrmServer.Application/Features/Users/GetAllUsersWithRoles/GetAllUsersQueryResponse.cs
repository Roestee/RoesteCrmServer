namespace RoesteCrmServer.Application.Features.Users.GetAllUsersWithRoles;

public sealed record GetAllUsersQueryResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string UserName,
    string Email,
    string PhoneNumber,
    string? Role);