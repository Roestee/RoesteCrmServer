using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Opportunities.UpdateOpportunity;

public sealed record UpdateOpportunityCommand(
    Guid Id,
    string Name,
    string? Description,
    string? Probability,
    decimal? Amount,
    DateTime CloseDate,
    Guid OpportunityOwnerId,
    Guid AccountId,
    Guid StageId,
    Guid ForecastCategoryId,
    Guid CreatedById,
    Guid ModifiedById): IRequest<Result<Opportunity>>;