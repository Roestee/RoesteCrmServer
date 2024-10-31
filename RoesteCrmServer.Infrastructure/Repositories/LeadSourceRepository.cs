using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class LeadSourceRepository: EfRepository<LeadSource, ApplicationDbContext>, ILeadSourceRepository
{
    public LeadSourceRepository(ApplicationDbContext context) : base(context)
    {
    }
}