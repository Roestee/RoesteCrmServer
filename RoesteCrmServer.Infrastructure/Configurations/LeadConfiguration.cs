using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class LeadConfiguration: IEntityTypeConfiguration<Lead>
{
    public void Configure(EntityTypeBuilder<Lead> builder)
    {
        builder.Property(l=>l.FirstName).IsRequired().HasColumnType("nvarchar(50)");
        builder.Property(l=>l.LastName).IsRequired().HasColumnType("nvarchar(50)");
        builder.Property(l=>l.Email).IsRequired().HasAnnotation("EmailAddress", true).HasMaxLength(100);
        builder.Property(l=>l.Title).HasColumnType("nvarchar(50)");
        builder.Property(l=>l.Phone).HasMaxLength(15);
        builder.Property(l=>l.Company).HasColumnType("nvarchar(100)");
        builder.Property(l=>l.Description).HasColumnType("nvarchar(max)");
        builder.Property(l=>l.Website).HasColumnType("nvarchar(150)");
        builder.HasOne(l=>l.Address)
            .WithMany()
            .HasForeignKey(l=>l.AddressId)
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(l => l.LeadOwner)
            .WithMany()
            .HasForeignKey(l => l.LeadOwnerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(l => l.CreatedBy)
            .WithMany()
            .HasForeignKey(l => l.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(l => l.ModifiedBy)
            .WithMany()
            .HasForeignKey(l => l.ModifiedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}