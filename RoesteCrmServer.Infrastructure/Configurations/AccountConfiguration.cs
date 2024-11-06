using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class AccountConfiguration: IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.Property(c=>c.Name).IsRequired().HasColumnType("nvarchar(150)");
        builder.Property(c=>c.Email).IsRequired().HasAnnotation("EmailAddress", true).HasMaxLength(100);
        builder.Property(c=>c.Phone).HasMaxLength(15);
        builder.Property(c=>c.Description).HasColumnType("nvarchar(max)");
        builder.Property(c=>c.Website).HasColumnType("nvarchar(150)");
        builder.HasOne(c=>c.BillingAddress)
            .WithMany()
            .HasForeignKey(c=>c.BillingAddressId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(c=>c.ShippingAddress)
            .WithMany()
            .HasForeignKey(c=>c.ShippingAddressId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(c => c.AccountOwner)
            .WithMany()
            .HasForeignKey(c => c.AccountOwnerId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(c => c.CreatedBy)
            .WithMany()
            .HasForeignKey(c => c.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(c => c.ModifiedBy)
            .WithMany()
            .HasForeignKey(c => c.ModifiedById)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(c => c.AccountType)
            .WithMany()
            .HasForeignKey(c => c.AccountTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}