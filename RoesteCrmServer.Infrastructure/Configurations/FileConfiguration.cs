using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = RoesteCrmServer.Domain.Entities.File;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.Property(f=>f.Path).IsRequired().HasColumnType("nvarchar(400)");
        builder.Property(f => f.Extension).IsRequired().HasColumnType("nvarchar(20)");
        builder.HasOne(f => f.Lead)
            .WithMany(l => l.Files)
            .HasForeignKey(f => f.LeadId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(f => f.Account)
            .WithMany(a => a.Files)
            .HasForeignKey(f => f.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(f => f.Contact)
            .WithMany(con => con.Files)
            .HasForeignKey(f => f.ContactId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(f => f.Opportunity)
            .WithMany(o => o.Files)
            .HasForeignKey(f => f.OpportunityId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}