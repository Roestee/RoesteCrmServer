using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.LeadSources.GetAllLeadSources;

internal sealed class GetAllLeadSourcesQueryHandler(ILeadSourceRepository leadSourceRepository) : IRequestHandler<GetAllLeadSourcesQuery, Result<List<LeadSource>>>
{
    public async Task<Result<List<LeadSource>>> Handle(GetAllLeadSourcesQuery request, CancellationToken cancellationToken)
    {
        var leadSources = await leadSourceRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return leadSources;
    }
}