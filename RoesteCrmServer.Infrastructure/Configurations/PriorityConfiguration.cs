using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class PriorityConfiguration: IEntityTypeConfiguration<Priority>
{
    public void Configure(EntityTypeBuilder<Priority> builder)
    {
        builder.Property(p=>p.Name).IsRequired().HasColumnType("nvarchar(10)");
        builder.HasData(new[]
        {
            new Priority { Id = Guid.NewGuid(), Name = "Yüksek" },
            new Priority { Id = Guid.NewGuid(), Name = "Orta" },
            new Priority { Id = Guid.NewGuid(), Name = "Düşük" },
        });
    }
}