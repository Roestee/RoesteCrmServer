using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Accounts.GetAccountByIdWithDetail;

public sealed record GetAccountByIdWithDetailQuery(Guid Id): IRequest<Result<Account>>;