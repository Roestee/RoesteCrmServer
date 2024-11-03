using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Entities;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal class ContactRepository : EfRepository<Contact, ApplicationDbContext>, IContactRepository
{
    public ContactRepository(ApplicationDbContext context) : base(context)
    {
    }
}