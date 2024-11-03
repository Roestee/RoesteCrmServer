using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Accounts.DeleteAccountById;

public sealed record DeleteAccountByIdCommand(Guid Id) : IRequest<Result<Account>>;