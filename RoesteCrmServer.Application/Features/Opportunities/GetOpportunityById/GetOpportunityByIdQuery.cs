using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Opportunities.GetOpportunityById;

public sealed record GetOpportunityByIdQuery(Guid Id): IRequest<Result<Opportunity>>;