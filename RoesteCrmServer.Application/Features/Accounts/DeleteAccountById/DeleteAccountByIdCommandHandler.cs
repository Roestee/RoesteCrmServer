using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Accounts.DeleteAccountById;

internal sealed class DeleteAccountByIdCommandHandler(
    IAccountRepository accountRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteAccountByIdCommand, Result<Account>>
{
    public async Task<Result<Account>> Handle(DeleteAccountByIdCommand request, CancellationToken cancellationToken)
    {
        var account = await accountRepository
            .Where(a => a.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);
        
        if(account is null)
            return Result<Account>.Failure("Hesap bulunamadı.");
        
        accountRepository.Delete(account);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Result<Account>.Succeed(account, "Hesap başarıyla silindi.");
    }
}