using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Opportunities.CreateOpportunity;

internal sealed class CreateOpportunityCommandHandler(
    IOpportunityRepository opportunityRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper): IRequestHandler<CreateOpportunityCommand, Result<Opportunity>>
{
    public async Task<Result<Opportunity>> Handle(CreateOpportunityCommand request, CancellationToken cancellationToken)
    {
        var opportunity = mapper.Map<Opportunity>(request);
        await opportunityRepository.AddAsync(opportunity, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Opportunity>.Succeed(opportunity, "Fırsat başarıyla oluşturuldu.");
    }
}