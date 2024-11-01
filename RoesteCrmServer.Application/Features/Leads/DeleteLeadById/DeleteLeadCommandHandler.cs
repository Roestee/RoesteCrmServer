using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.DeleteLeadById;

internal sealed class DeleteLeadCommandHandler(
    ILeadRepository leadRepository,
    IUnitOfWork unitOfWork): IRequestHandler<DeleteLeadByIdCommand, Result<Lead>>
{
    public async Task<Result<Lead>> Handle(DeleteLeadByIdCommand request, CancellationToken cancellationToken)
    {
        var lead = await leadRepository
            .Where(l => l.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if(lead is null)
            return Result<Lead>.Failure("Potansiyel müşteri bulunamadı.");
        
        leadRepository.Delete(lead);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Lead>.Succeed(lead, "Potansiyel müşteri başarıyla silindi.");
    }
}