using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.CaseOrigins.GetAllCaseOrigins;

internal sealed class GetAllCaseOriginsQueryHandler(
    ICaseOriginRepository caseOriginRepository): IRequestHandler<GetAllCaseOriginsQuery, Result<List<CaseOrigin>>>
{
    public async Task<Result<List<CaseOrigin>>> Handle(GetAllCaseOriginsQuery request, CancellationToken cancellationToken)
    {
        var caseOrigins = await caseOriginRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return caseOrigins;
    }
}