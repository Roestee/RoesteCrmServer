using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Accounts.UpdateAccount;

internal sealed class UpdateAccountCommandHandler(
    IAccountRepository accountRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork) : IRequestHandler<UpdateAccountCommand, Result<Account>>
{
    public async Task<Result<Account>> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = await accountRepository
            .WhereWithTracking(a => a.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (account is null)
            return Result<Account>.Failure("Hesap bulunamadı.");

        var isEmailExist =
            await accountRepository.AnyAsync(a => a.Id != request.Id && a.Email == request.Email, cancellationToken);
        if (isEmailExist)
            return Result<Account>.Failure("Eposta adresi daha önce kaydedilmiş.");

        mapper.Map(request, account);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var updatedAccount = await accountRepository
            .Where(a => a.Id == request.Id)
            .Include(a => a.AccountType)
            .Include(a => a.AccountOwner)
            .Include(a => a.Industry)
            .Include(a => a.BillingAddress)
            .Include(a => a.ShippingAddress)
            .Include(a => a.CreatedBy)
            .Include(a => a.ModifiedBy)
            .Include(a => a.Contacts)
            .Include(a => a.Opportunities)
            .FirstOrDefaultAsync(cancellationToken);

        return updatedAccount is null
            ? Result<Account>.Failure("Hesap bulunamadı!")
            : Result<Account>.Succeed(updatedAccount, "Hesap başarıyla güncellendi.");
    }
}