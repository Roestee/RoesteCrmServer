using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class CaseOriginRepository: EfRepository<CaseOrigin, ApplicationDbContext>, ICaseOriginRepository
{
    public CaseOriginRepository(ApplicationDbContext context) : base(context)
    {
    }
}