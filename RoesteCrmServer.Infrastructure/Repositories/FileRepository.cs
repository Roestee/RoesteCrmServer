using RoesteCrmServer.Domain.Abstract.EntityFrameworkCore;
using RoesteCrmServer.Domain.Repositories;
using RoesteCrmServer.Infrastructure.Context;
using File = RoesteCrmServer.Domain.Entities.File;

namespace RoesteCrmServer.Infrastructure.Repositories;

internal sealed class FileRepository(ApplicationDbContext context)
    : EfRepository<File, ApplicationDbContext>(context), IFileRepository;