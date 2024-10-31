using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Context;

public sealed class ApplicationDbContext : IdentityDbContext<
    AppUser,
    IdentityRole<Guid>,
    Guid>, IUnitOfWork
{
    public DbSet<Lead> Leads { get; set; }
    public DbSet<LeadStatus> LeadStatuses { get; set; }
    public DbSet<Salutation> Salutations { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<LeadSource> LeadSources { get; set; }
    public DbSet<Industry> Industries { get; set; }

    public ApplicationDbContext()
    {
        
    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);

        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();

        builder.Entity<IdentityUserRole<Guid>>()
             .HasKey(ur => new { ur.UserId, ur.RoleId });
    }
}