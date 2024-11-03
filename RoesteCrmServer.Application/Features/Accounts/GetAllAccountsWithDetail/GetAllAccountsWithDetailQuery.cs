using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Accounts.GetAllAccountsWithDetail;

public sealed record GetAllAccountsWithDetailQuery: IRequest<Result<List<Account>>>;