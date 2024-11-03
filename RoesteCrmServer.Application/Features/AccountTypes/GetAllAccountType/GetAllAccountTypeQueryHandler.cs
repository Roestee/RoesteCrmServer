using MediatR;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Application.Utilities.Results;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;

namespace RoesteCrmServer.Application.Features.AccountTypes.GetAllAccountType;

internal sealed class GetAllAccountTypeQueryHandler(
    IAccountTypeRepository accountTypeRepository): IRequestHandler<GetAllAccountTypeQuery, Result<List<AccountType>>>
{
    public async Task<Result<List<AccountType>>> Handle(GetAllAccountTypeQuery request, CancellationToken cancellationToken)
    {
        var accountTypes = await accountTypeRepository
            .GetAll()
            .ToListAsync(cancellationToken);
        
        return accountTypes;
    }
}