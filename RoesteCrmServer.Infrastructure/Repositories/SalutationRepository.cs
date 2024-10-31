using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class SalutationRepository: EfRepository<Salutation, ApplicationDbContext>, ISalutationRepository
{
    public SalutationRepository(ApplicationDbContext context) : base(context)
    {
    }
}