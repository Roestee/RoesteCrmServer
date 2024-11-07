using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Opportunities.CreateOpportunity;

public sealed record CreateOpportunityCommand(
    string Name,
    string? Description,
    string? Probability,
    decimal? Amount,
    DateTime CloseDate,
    Guid OpportunityOwnerId,
    Guid AccountId,
    Guid StageId,
    Guid ForecastCategoryId): IRequest<Result<Opportunity>>;