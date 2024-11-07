using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Cases.GetCaseById;

public sealed record GetCaseByIdQuery(Guid Id): IRequest<Result<Case>>;