using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Accounts.GetAccountByIdWithDetail;

internal sealed class GetAccountByIdQueryHandler(
    IAccountRepository accountRepository): IRequestHandler<GetAccountByIdWithDetailQuery, Result<Account>>
{
    public async Task<Result<Account>> Handle(GetAccountByIdWithDetailQuery request, CancellationToken cancellationToken)
    {
        var account = await accountRepository
            .Where(a => a.Id == request.Id)
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
            .FirstOrDefaultAsync(cancellationToken);
        
        return account ?? Result<Account>.Failure("Hesap bulunamadı!");
    }
}