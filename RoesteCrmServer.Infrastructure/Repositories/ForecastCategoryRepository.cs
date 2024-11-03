using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class ForecastCategoryRepository: EfRepository<ForecastCategory, ApplicationDbContext>, IForecastCategoryRepository
{
    public ForecastCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}