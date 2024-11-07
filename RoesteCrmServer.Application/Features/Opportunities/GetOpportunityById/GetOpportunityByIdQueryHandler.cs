using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Opportunities.GetOpportunityById;

internal sealed class GetOpportunityByIdQueryHandler(
    IOpportunityRepository opportunityRepository): IRequestHandler<GetOpportunityByIdQuery, Result<Opportunity>>
{
    public async Task<Result<Opportunity>> Handle(GetOpportunityByIdQuery request, CancellationToken cancellationToken)
    {
        var opportunity = await opportunityRepository
            .Where(o => o.Id == request.Id)
            .Include(o => o.OpportunityOwner)
            .Include(o => o.Account)
            .Include(o => o.Stage)
            .Include(o => o.ForecastCategory)
            .Include(o => o.CreatedBy)
            .Include(o => o.ModifiedBy)
            .FirstOrDefaultAsync(cancellationToken);
        
        return opportunity ?? Result<Opportunity>.Failure("Fırsat bulunamadı!");
    }
}