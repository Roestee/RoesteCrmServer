using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Addresses.GetAllAddresses;

internal sealed class GetAllAddressesQueryHandler(
    IAddressRepository addressRepository) : IRequestHandler<GetAllAddressesQuery, Result<List<Address>>>
{
    public async Task<Result<List<Address>>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        var addresses = await addressRepository
            .GetAll()
            .ToListAsync(cancellationToken);

        return addresses;
    }
}