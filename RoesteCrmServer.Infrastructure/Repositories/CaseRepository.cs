using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class CaseRepository: EfRepository<Case, ApplicationDbContext>, ICaseRepository
{
    public CaseRepository(ApplicationDbContext context) : base(context)
    {
    }
}