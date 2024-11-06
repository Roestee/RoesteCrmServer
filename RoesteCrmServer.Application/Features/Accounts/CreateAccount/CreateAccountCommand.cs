using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Application.Features.Accounts.CreateAccount;

public sealed record CreateAccountCommand(
    string Name,
    string Email,
    string? Phone,
    string? Website,
    string? Description,
    Guid AccountOwnerId, 
    Guid IndustryId, 
    Guid AccountTypeId,
    Guid CreatedById,
    Guid ModifiedById,
    AccountType AccountType,
    Address? BillingAddress,
    Address? ShippingAddress): IRequest<Result<Account>>;