using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class AddressConfiguration: IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.Property(a=>a.City).HasColumnType("nvarchar(50)");
        builder.Property(a=>a.Country).HasColumnType("nvarchar(50)");
        builder.Property(a=>a.State).HasColumnType("nvarchar(50)");
        builder.Property(a=>a.Street).HasColumnType("nvarchar(max)");
        builder.Property(a=>a.PostalCode).HasColumnType("nvarchar(50)");
        
        
    }
}