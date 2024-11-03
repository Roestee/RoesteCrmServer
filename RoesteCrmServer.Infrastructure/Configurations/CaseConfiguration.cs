using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class CaseConfiguration: IEntityTypeConfiguration<Case>
{
    public void Configure(EntityTypeBuilder<Case> builder)
    {
        builder.Property(c=>c.Subject).IsRequired().HasColumnType("nvarchar(200)");
        builder.Property(c=>c.Description).IsRequired().HasColumnType("nvarchar(max)");
        builder.HasOne(c => c.CaseOwner)
            .WithMany()
            .HasForeignKey(c => c.CaseOwnerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(co => co.CreatedBy)
            .WithMany()
            .HasForeignKey(co => co.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(co => co.ModifiedBy)
            .WithMany()
            .HasForeignKey(co => co.ModifiedById)
            .OnDelete(DeleteBehavior.Restrict);
    }
}