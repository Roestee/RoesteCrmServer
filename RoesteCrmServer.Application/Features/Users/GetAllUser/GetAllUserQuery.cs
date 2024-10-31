using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Users.GetAllUser;

public sealed record GetAllUserQuery : IRequest<Result<List<AppUser>>>;