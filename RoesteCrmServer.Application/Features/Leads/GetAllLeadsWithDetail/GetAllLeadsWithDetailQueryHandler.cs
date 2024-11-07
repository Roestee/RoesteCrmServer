using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.GetAllLeadsWithDetail;

internal sealed class GetAllLeadsWithDetailQueryHandler(
    ILeadRepository leadRepository): IRequestHandler<GetAllLeadsWithDetailQuery, Result<List<Lead>>>
{
    public async Task<Result<List<Lead>>> Handle(GetAllLeadsWithDetailQuery request, CancellationToken cancellationToken)
    {
        var leads = await leadRepository.GetAll()
            .Include(l=>l.LeadSource)
            .Include(l=>l.LeadStatus)
            .Include(l=>l.CreatedBy)
            .Include(l=>l.ModifiedBy)
            .Include (l=>l.Industry)
            .Include(l => l.Address)
            .Include(l => l.Rating)
            .Include(l => l.Salutation)
            .Include(l=>l.LeadOwner)
            .Include(a=>a.Files)
            .ToListAsync(cancellationToken);

        return leads;
    }
}