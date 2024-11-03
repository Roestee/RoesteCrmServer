using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class ForecastCategoryConfiguration: IEntityTypeConfiguration<ForecastCategory>
{
    public void Configure(EntityTypeBuilder<ForecastCategory> builder)
    {
        builder.Property(f=>f.Name).HasColumnType("nvarchar(30)");
        builder.HasData(new[]
        {
            new ForecastCategory { Id= Guid.NewGuid(), Name = "Önceliği Düşük" },
            new ForecastCategory { Id= Guid.NewGuid(), Name = "Satışta" },
            new ForecastCategory { Id= Guid.NewGuid(), Name = "En İyi Durum" },
            new ForecastCategory { Id= Guid.NewGuid(), Name = "Taahhüt Edilmiş" },
            new ForecastCategory { Id= Guid.NewGuid(), Name = "Kapandı" },
        });
    }
}