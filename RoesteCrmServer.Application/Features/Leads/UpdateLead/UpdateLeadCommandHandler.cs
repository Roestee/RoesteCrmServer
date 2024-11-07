using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.UpdateLead;

internal sealed class UpdateLeadCommandHandler(
    ILeadRepository leadRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateLeadCommand, Result<Lead>>
{
    public async Task<Result<Lead>> Handle(UpdateLeadCommand request, CancellationToken cancellationToken)
    {
        var lead = await leadRepository
            .WhereWithTracking(l => l.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if(lead is null)
            return Result<Lead>.Failure("Müşteri bulunamadı");
            
        mapper.Map(request, lead);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var updatedLead = await leadRepository
            .Where(l => l.Id == request.Id)
            .Include(l=>l.Address)
            .Include(l => l.Salutation)
            .Include(l => l.Rating)
            .Include(l => l.Industry)
            .Include(l => l.LeadOwner)
            .Include(l => l.LeadStatus)
            .Include(l => l.LeadSource)
            .Include(l => l.CreatedBy)
            .Include(l => l.ModifiedBy)
            .Include(a=>a.Files)
            .FirstOrDefaultAsync(cancellationToken);
        
        return 
            updatedLead is null
                ? Result<Lead>.Failure("Güncellenen müşteri bulunamadı!")
                : Result<Lead>.Succeed(updatedLead, "Müşteri başarıyla güncellendi.");
    }
}