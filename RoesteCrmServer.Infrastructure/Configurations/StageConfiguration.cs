using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class StageConfiguration: IEntityTypeConfiguration<Stage>
{
    public void Configure(EntityTypeBuilder<Stage> builder)
    {
        builder.Property(s=>s.Name).IsRequired().HasColumnType("nvarchar(30)");
        builder.HasData(new[]
        {
            new Stage { Id = Guid.NewGuid(), Name = "Hazırlık" },
            new Stage { Id = Guid.NewGuid(), Name = "Buluşma & Tanışma" },
            new Stage { Id = Guid.NewGuid(), Name = "Teklif" },
            new Stage { Id = Guid.NewGuid(), Name = "Pazarlık" },
            new Stage { Id = Guid.NewGuid(), Name = "Kapandı-Kazanıldı" },
            new Stage { Id = Guid.NewGuid(), Name = "Kapandı-Kaybedildi" },
        });
    }
}