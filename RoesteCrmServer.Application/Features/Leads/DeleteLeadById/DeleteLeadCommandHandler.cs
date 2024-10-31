using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Leads.DeleteLeadById;

internal sealed class DeleteLeadCommandHandler(
    ILeadRepository leadRepository,
    IUnitOfWork unitOfWork): IRequestHandler<DeleteLeadByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteLeadByIdCommand request, CancellationToken cancellationToken)
    {
        var lead = await leadRepository
            .Where(l => l.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        if(lead is null)
            return Result<string>.Failure("Potansiyel müşteri bulunamadı.");
        
        leadRepository.Delete(lead);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Potansiyel müşteri başarıyla silindi.";
    }
}