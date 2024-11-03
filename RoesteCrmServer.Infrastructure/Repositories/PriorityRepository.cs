using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class PriorityRepository: EfRepository<Priority, ApplicationDbContext>, IPriorityRepository
{
    public PriorityRepository(ApplicationDbContext context) : base(context)
    {
    }
}