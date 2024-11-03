using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Priorities.GetAllPriorities;

public sealed record GetAllPrioritiesQuery: IRequest<Result<List<Priority>>>;