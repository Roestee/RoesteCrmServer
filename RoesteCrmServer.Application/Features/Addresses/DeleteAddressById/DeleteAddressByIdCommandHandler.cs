using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Addresses.DeleteAddressById;

internal sealed class DeleteAddressByIdCommandHandler(
    IAddressRepository addressRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteAddressByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteAddressByIdCommand request, CancellationToken cancellationToken)
    {
        var address = await addressRepository
            .Where(a => a.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        
        if(address == null)
            return Result<string>.Failure("Adres bulunamadı!");
        
        addressRepository.Delete(address);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return "Adres başarıyla silindi.";
    }
}