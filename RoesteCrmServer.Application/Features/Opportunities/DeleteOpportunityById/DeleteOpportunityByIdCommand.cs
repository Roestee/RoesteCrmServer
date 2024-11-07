using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Opportunities.DeleteOpportunityById;

public sealed record DeleteOpportunityByIdCommand(Guid Id): IRequest<Result<Opportunity>>;