using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.CreateLead;

internal sealed class CreateLeadCommandHandler(
    ILeadRepository leadRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper): IRequestHandler<CreateLeadCommand, Result<Lead>>
{
    public async Task<Result<Lead>> Handle(CreateLeadCommand request, CancellationToken cancellationToken)
    {
        var address = mapper.Map<Address>(request.Address);
        var lead = mapper.Map<Lead>(request);
        lead.Address = address;
        await leadRepository.AddAsync(lead, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Lead>.Succeed(lead, "Potansiyel müşteri başarıyla kaydedildi.");
    }
}