using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.CaseStatuses.GetAllCaseStatuses;

internal sealed class GetAllCaseStatusesQueryHandler(
    ICaseStatusRepository caseStatusRepository): IRequestHandler<GetAllCaseStatusesQuery, Result<List<CaseStatus>>>
{
    public async Task<Result<List<CaseStatus>>> Handle(GetAllCaseStatusesQuery request, CancellationToken cancellationToken)
    {
        var caseStatuses = await caseStatusRepository
            .GetAll()
            .ToListAsync(cancellationToken);
        
        return caseStatuses;
    }
}