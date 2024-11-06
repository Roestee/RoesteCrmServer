using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class ContactConfiguration: IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(co=>co.FirstName).IsRequired().HasColumnType("nvarchar(50)");
        builder.Property(co=>co.LastName).IsRequired().HasColumnType("nvarchar(50)");
        builder.Property(co=>co.Email).IsRequired().HasAnnotation("EmailAddress", true).HasMaxLength(100);
        builder.Property(co=>co.MiddleName).HasColumnType("nvarchar(50)");
        builder.Property(co=>co.Title).HasColumnType("nvarchar(50)");
        builder.Property(co=>co.Phone).HasMaxLength(15);
        builder.Property(co=>co.Description).HasColumnType("nvarchar(max)");
        builder.Property(co=>co.Website).HasColumnType("nvarchar(150)");
        builder.Property(co=>co.Department).HasColumnType("nvarchar(150)");
        builder.HasOne(co => co.MailingAddress)
            .WithMany()
            .HasForeignKey(co => co.MailingAddressId);
        builder.HasOne(co => co.OtherAddress)
            .WithMany()
            .HasForeignKey(co => co.OtherAddressId);
        builder.HasOne(co => co.ContactOwner)
            .WithMany()
            .HasForeignKey(co => co.ContactOwnerId)
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