using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.AccountTypes.GetAllAccountType;

public sealed record GetAllAccountTypeQuery: IRequest<Result<List<AccountType>>>;