using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class CaseStatusRepository: EfRepository<CaseStatus, ApplicationDbContext>, ICaseStatusRepository
{
    public CaseStatusRepository(ApplicationDbContext context) : base(context)
    {
    }
}