using MediatR;
using RoesteCrmServer.Application.Utilities.Results;

namespace RoesteCrmServer.Application.Features.Addresses.DeleteAddressById;

public sealed record DeleteAddressByIdCommand(Guid Id): IRequest<Result<string>>;