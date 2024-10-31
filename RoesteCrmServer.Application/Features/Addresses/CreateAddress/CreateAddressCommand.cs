using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Addresses.CreateAddress;

public sealed record CreateAddressCommand(
    string Country,
    string State,
    string City,
    string Street,
    string PostalCode) : IRequest<Result<string>>;