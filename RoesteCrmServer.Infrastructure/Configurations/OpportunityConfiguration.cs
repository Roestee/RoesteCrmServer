using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class OpportunityConfiguration: IEntityTypeConfiguration<Opportunity>
{
    public void Configure(EntityTypeBuilder<Opportunity> builder)
    {
        builder.Property(o=>o.Name).IsRequired().HasColumnType("nvarchar(30)");
        builder.Property(o=>o.Description).HasColumnType("nvarchar(max)");
        builder.Property(o=>o.Probability).HasColumnType("nvarchar(20)");
        builder.Property(o => o.Amount).HasPrecision(12, 2);
        builder.HasOne(o => o.OpportunityOwner)
            .WithMany()
            .HasForeignKey(o => o.OpportunityOwnerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(o => o.CreatedBy)
            .WithMany()
            .HasForeignKey(o => o.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(o => o.ModifiedBy)
            .WithMany()
            .HasForeignKey(o => o.ModifiedById)
            .OnDelete(DeleteBehavior.Restrict);
    }
}