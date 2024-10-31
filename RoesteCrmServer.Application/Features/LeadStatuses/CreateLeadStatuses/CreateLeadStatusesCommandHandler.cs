using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.LeadStatuses.CreateLeadStatuses;

internal sealed class CreateLeadStatusesCommandHandler(
    ILeadStatusRepository leadStatusRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper): IRequestHandler<CreateLeadStatusesCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateLeadStatusesCommand request, CancellationToken cancellationToken)
    {
        var leadStatus = mapper.Map<LeadStatus>(request);
        await leadStatusRepository.AddAsync(leadStatus, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return "Potansiyel müşteri başarıyla oluşturuldu.";
    }
}