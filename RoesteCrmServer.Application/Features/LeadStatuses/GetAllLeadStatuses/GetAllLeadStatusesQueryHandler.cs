using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.LeadStatuses.GetAllLeadStatuses;

internal sealed class GetAllLeadStatusesQueryHandler(
    ILeadStatusRepository leadStatusRepository): IRequestHandler<GetAllLeadStatusesQuery, Result<List<LeadStatus>>>
{
    public async Task<Result<List<LeadStatus>>> Handle(GetAllLeadStatusesQuery request, CancellationToken cancellationToken)
    {
        var leadStatuses = await leadStatusRepository.GetAll().ToListAsync(cancellationToken);
        return leadStatuses;
    }
}