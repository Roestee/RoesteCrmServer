using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class RatingRepository: EfRepository<Rating, ApplicationDbContext>, IRatingRepository
{
    public RatingRepository(ApplicationDbContext context) : base(context)
    {
    }
}