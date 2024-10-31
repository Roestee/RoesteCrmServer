using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Addresses.CreateAddress;

internal sealed class CreateAddressCommandHandler(
    IAddressRepository addressRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateAddressCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = mapper.Map<Address>(request);
        await addressRepository.AddAsync(address, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Adres başarıyla eklendi.";
    }   
}