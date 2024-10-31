using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class LeadRepository: EfRepository<Lead, ApplicationDbContext>, ILeadRepository
{
    public LeadRepository(ApplicationDbContext context) : base(context)
    {
    }
}