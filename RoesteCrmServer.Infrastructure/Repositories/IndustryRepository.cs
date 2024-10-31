using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class IndustryRepository: EfRepository<Industry, ApplicationDbContext>, IIndustryRepository
{
    public IndustryRepository(ApplicationDbContext context) : base(context)
    {
    }
}