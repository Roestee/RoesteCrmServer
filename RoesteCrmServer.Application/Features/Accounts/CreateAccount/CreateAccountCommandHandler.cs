using AutoMapper;
using MediatR;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.Accounts.CreateAccount;

internal sealed class CreateAccountCommandHandler(
    IAccountRepository accountRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork): IRequestHandler<CreateAccountCommand, Result<Account>>
{
    public async Task<Result<Account>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        var isEmailExist = await accountRepository.AnyAsync(a=>a.Email == request.Email, cancellationToken);
        if(isEmailExist)
            return Result<Account>.Failure("Email daha önce kullanılmış!");
            
        var account = mapper.Map<Account>(request);
        await accountRepository.AddAsync(account, cancellationToken);
            
        return Result<Account>.Succeed(account, "Hesap başarıyla oluşturuldu.");
    }
}