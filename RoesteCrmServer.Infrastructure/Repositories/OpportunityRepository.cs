using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class OpportunityRepository: EfRepository<Opportunity, ApplicationDbContext>, IOpportunityRepository
{
    public OpportunityRepository(ApplicationDbContext context) : base(context)
    {
    }
}