using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Cases.DeleteCaseById;

public sealed record DeleteCaseByIdCommand(Guid Id): IRequest<Result<Case>>;