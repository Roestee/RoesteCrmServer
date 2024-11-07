using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Opportunities.GetAllOpportunities;

internal sealed class GetAllOpportunitiesQueryHandler(
    IOpportunityRepository opportunityRepository) : IRequestHandler<GetAllOpportunitiesQuery, Result<List<Opportunity>>>
{
    public async Task<Result<List<Opportunity>>> Handle(GetAllOpportunitiesQuery request, CancellationToken cancellationToken)
    {
        var opportunities = await opportunityRepository
            .GetAll()
            .Include(o => o.OpportunityOwner)
            .Include(o => o.Account)
            .Include(o => o.Stage)
            .Include(o => o.ForecastCategory)
            .Include(o => o.CreatedBy)
            .Include(o => o.ModifiedBy)
            .Include(a=>a.Files)
            .ToListAsync(cancellationToken);

        return opportunities;
    }
}