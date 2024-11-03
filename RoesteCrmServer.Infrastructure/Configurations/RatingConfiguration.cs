using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class RatingConfiguration: IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.Property(r=>r.Name).IsRequired().HasColumnType("nvarchar(20)");
        builder.HasData(
            new Rating {Id= Guid.NewGuid(), Name = "Sıcak" },
            new Rating {Id= Guid.NewGuid(), Name = "Ilık" },
            new Rating { Id = Guid.NewGuid(), Name = "Soğuk" });
    }
}