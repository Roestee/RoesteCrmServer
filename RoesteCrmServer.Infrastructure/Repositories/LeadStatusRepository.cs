using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class LeadStatusRepository: EfRepository<LeadStatus, ApplicationDbContext>, ILeadStatusRepository
{
    public LeadStatusRepository(ApplicationDbContext context) : base(context)
    {
    }
}