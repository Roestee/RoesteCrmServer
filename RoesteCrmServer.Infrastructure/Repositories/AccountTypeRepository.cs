using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class AccountTypeRepository: EfRepository<AccountType, ApplicationDbContext>, IAccountTypeRepository
{
    public AccountTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}