using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Accounts.GetAllAccountsWithDetail;

internal sealed class GetAllAccountsWithDetailQueryHandler(
    IAccountRepository accountRepository): IRequestHandler<GetAllAccountsWithDetailQuery, Result<List<Account>>>
{
    public async Task<Result<List<Account>>> Handle(GetAllAccountsWithDetailQuery request, CancellationToken cancellationToken)
    {
        var accounts = await accountRepository
            .GetAll()
            .Include(a => a.AccountType)
            .Include(a => a.AccountOwner)
            .Include(a => a.Industry)
            .Include(a => a.BillingAddress)
            .Include(a => a.ShippingAddress)
            .Include(a => a.CreatedBy)
            .Include(a => a.ModifiedBy)
            .Include(a=>a.Contacts)
            .Include(a=>a.Opportunities)
            .Include(a=>a.Files)
            .ToListAsync(cancellationToken);
        return accounts;
    }
}