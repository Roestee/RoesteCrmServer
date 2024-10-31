using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Addresses.GetAllAddresses;

public sealed record GetAllAddressesQuery: IRequest<Result<List<Address>>>;