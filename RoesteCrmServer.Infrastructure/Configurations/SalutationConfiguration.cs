using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class SalutationConfiguration: IEntityTypeConfiguration<Salutation>
{
    public void Configure(EntityTypeBuilder<Salutation> builder)
    {
        builder.Property(x=>x.Name).IsRequired().HasColumnType("nvarchar(10)");
        builder.HasData(new[]
        {
            new Salutation { Name = "Mr." },
            new Salutation { Name = "Ms." },
            new Salutation { Name = "Mrs." },
            new Salutation { Name = "Dr." },
            new Salutation { Name = "Prof." },
            new Salutation { Name = "Mx." }
        });
    }
}