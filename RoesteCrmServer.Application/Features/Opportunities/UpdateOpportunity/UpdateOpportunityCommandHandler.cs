using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Opportunities.UpdateOpportunity;

internal sealed class UpdateOpportunityCommandHandler(
    IOpportunityRepository opportunityRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateOpportunityCommand, Result<Opportunity>>
{
    public async Task<Result<Opportunity>> Handle(UpdateOpportunityCommand request, CancellationToken cancellationToken)
    {
        var opportunity = await opportunityRepository
            .WhereWithTracking(o => o.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if (opportunity is null)
            return Result<Opportunity>.Failure("Güncellenmek istenen fırsat bulunamadı!");
            
        mapper.Map(request, opportunity);
        await unitOfWork.SaveChangesAsync(cancellationToken);
            
        return Result<Opportunity>.Succeed(opportunity, "Fırsat başarıyla güncellendi.");
    }
}