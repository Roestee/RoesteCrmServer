using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class StageRepository: EfRepository<Stage, ApplicationDbContext>, IStageRepository
{
    public StageRepository(ApplicationDbContext context) : base(context)
    {
    }
}