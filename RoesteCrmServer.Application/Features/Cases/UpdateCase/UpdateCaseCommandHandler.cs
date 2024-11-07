using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Cases.UpdateCase;

internal sealed class UpdateCaseCommandHandler(
    ICaseRepository caseRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork): IRequestHandler<UpdateCaseCommand, Result<Case>>
{
    public async Task<Result<Case>> Handle(UpdateCaseCommand request, CancellationToken cancellationToken)
    {
        var @case = await caseRepository
            .WhereWithTracking(c => c.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if (@case == null)
            Result<Case>.Failure("Güncellenmek istenen dosya bulunamadı!");
            
        mapper.Map(@case, request);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var updatedCase = await caseRepository
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

        return updatedCase == null
            ? Result<Case>.Failure("Güncellenen dosya bulunamadı!")
            : Result<Case>.Succeed(updatedCase, "Dosya başarıyla güncellendi.");
    }
}