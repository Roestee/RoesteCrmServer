using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.GetLeadByIdWithDetail;

internal sealed class GetLeadByIdWithDetailQueryHandler(
    ILeadRepository leadRepository) : IRequestHandler<GetLeadByIdWithDetailQuery, Result<Lead>>
{
    public async Task<Result<Lead>> Handle(GetLeadByIdWithDetailQuery request, CancellationToken cancellationToken)
    {
        var lead = await leadRepository
            .Where(l => l.Id == request.Id)
            .Include(l=>l.Address)
            .Include(l=>l.Salutation)
            .Include(l=>l.Rating)
            .Include(l=>l.Industry)
            .Include(l=>l.LeadOwner)
            .Include(l=>l.LeadStatus)
            .Include(l=>l.LeadSource)
            .Include(l=>l.CreatedBy)
            .Include(l=>l.ModifiedBy)
            .FirstOrDefaultAsync(cancellationToken);
        
        return lead ?? Result<Lead>.Failure("Potansiyel müşteri bulunamadı!");
    }
}