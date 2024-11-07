using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Cases.GetAllCases;

internal sealed class GetAllCasesQueryHandler(
    ICaseRepository caseRepository): IRequestHandler<GetAllCasesQuery, Result<List<Case>>>
{
    public async Task<Result<List<Case>>> Handle(GetAllCasesQuery request, CancellationToken cancellationToken)
    {
        var cases = await caseRepository
            .GetAll()
            .Include(c => c.CaseStatus)
            .Include(c => c.CaseOrigin)
            .Include(c => c.Priority)
            .Include(c => c.CaseOwner)
            .Include(c => c.Contact)
            .Include(c => c.Account)
            .Include(c => c.CreatedBy)
            .Include(c => c.ModifiedBy)
            .ToListAsync(cancellationToken);

        return cases;
    }
}