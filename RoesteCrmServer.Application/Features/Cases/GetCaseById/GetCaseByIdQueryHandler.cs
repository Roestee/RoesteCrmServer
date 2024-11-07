using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Cases.GetCaseById;

internal sealed class GetCaseByIdQueryHandler(
    ICaseRepository caseRepository): IRequestHandler<GetCaseByIdQuery, Result<Case>>
{
    public async Task<Result<Case>> Handle(GetCaseByIdQuery request, CancellationToken cancellationToken)
    {
        var @case = await caseRepository
            .Where(c => c.Id == request.Id)
            .Include(c => c.CaseStatus)
            .Include(c => c.CaseOrigin)
            .Include(c => c.Priority)
            .Include(c => c.CaseOwner)
            .Include(c => c.Contact)
            .Include(c => c.Account)
            .Include(c => c.CreatedBy)
            .Include(c => c.ModifiedBy)
            .FirstOrDefaultAsync(cancellationToken);

        return @case ?? Result<Case>.Failure("Dosya bulunamadı!");
    }
}