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
            new Salutation {Id= Guid.NewGuid(), Name = "Bay" },
            new Salutation {Id= Guid.NewGuid(), Name = "Bayan" },
            new Salutation {Id= Guid.NewGuid(), Name = "Dr." },
            new Salutation {Id= Guid.NewGuid(), Name = "Prof." },
            new Salutation {Id= Guid.NewGuid(), Name = "Müh." }
        });
    }
}