﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoesteCrmServer.Domain.Abstract;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<
    AppUser,
    IdentityRole<Guid>,
    Guid>(options), IUnitOfWork
{
    public DbSet<Lead> Leads { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Opportunity> Opportunities { get; set; }
    public DbSet<Case> Cases { get; set; }
    
    public DbSet<LeadStatus> LeadStatuses { get; set; }
    public DbSet<Salutation> Salutations { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<LeadSource> LeadSources { get; set; }
    public DbSet<Industry> Industries { get; set; }
    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<Stage> Stages { get; set; }
    public DbSet<ForecastCategory> ForecastCategories { get; set; }
    public DbSet<CaseStatus> CaseStatuses { get; set; }
    public DbSet<CaseOrigin> CaseOrigins { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Domain.Entities.File> Files { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);

        builder.Ignore<IdentityUserLogin<Guid>>();
        builder.Ignore<IdentityUserToken<Guid>>();

        builder.Entity<IdentityUserRole<Guid>>()
             .HasKey(ur => new { ur.UserId, ur.RoleId });
    }
}