using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Opportunities.DeleteOpportunityById;

internal sealed class DeleteOpportunityByIdCommandHandler(
    IOpportunityRepository opportunityRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteOpportunityByIdCommand, Result<Opportunity>>
{
    public async Task<Result<Opportunity>> Handle(DeleteOpportunityByIdCommand request, CancellationToken cancellationToken)
    {
        var opportunity = await opportunityRepository
            .WhereWithTracking(o => o.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if (opportunity is null)
            return Result<Opportunity>.Failure("Silinmek istenen fırsat bulunamadı!");
        
        opportunityRepository.Delete(opportunity);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Opportunity>.Succeed(opportunity, "Fırsat başarıyla silindi.");
    }
}