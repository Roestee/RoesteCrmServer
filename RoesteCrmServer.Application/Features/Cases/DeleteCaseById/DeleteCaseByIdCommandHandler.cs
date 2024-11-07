using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Cases.DeleteCaseById;

internal sealed class DeleteCaseByIdCommandHandler(
    ICaseRepository caseRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteCaseByIdCommand, Result<Case>>
{
    public async Task<Result<Case>> Handle(DeleteCaseByIdCommand request, CancellationToken cancellationToken)
    {
        var @case = await caseRepository
            .Where(c => c.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if (@case == null)
            Result<Case>.Failure("Silinmek istenen dosya bulunamadı!");
        
        caseRepository.Delete(@case!);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Case>.Succeed(@case!, "Dosya başarıyla silindi.");
    }
}