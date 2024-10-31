using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class IndustryConfiguration: IEntityTypeConfiguration<Industry>
{
    public void Configure(EntityTypeBuilder<Industry> builder)
    {
        builder.Property(x=>x.Name).IsRequired().HasColumnType("nvarchar(50)");
        builder.HasData(new[]
        {
            new Industry { Name = "Agriculture" },
            new Industry { Name = "Apparel" },
            new Industry { Name = "Banking" },
            new Industry { Name = "Biotechnology" },
            new Industry { Name = "Chemicals" },
            new Industry { Name = "Communications" },
            new Industry { Name = "Construction" },
            new Industry { Name = "Consulting" },
            new Industry { Name = "Education" },
            new Industry { Name = "Electronics" },
            new Industry { Name = "Energy" },
            new Industry { Name = "Engineering" },
            new Industry { Name = "Entertainment" },
            new Industry { Name = "Environmental" },
            new Industry { Name = "Finance" },
            new Industry { Name = "Food & Beverage" },
            new Industry { Name = "Government" },
            new Industry { Name = "Healthcare" },
            new Industry { Name = "Hospitality" },
            new Industry { Name = "Insurance" },
            new Industry { Name = "Machinery" },
            new Industry { Name = "Manufacturing" },
            new Industry { Name = "Media" },
            new Industry { Name = "Not for Profit" },
            new Industry { Name = "Other" },
            new Industry { Name = "Recreation" },
            new Industry { Name = "Retail" },
            new Industry { Name = "Shipping" },
            new Industry { Name = "Technology" },
            new Industry { Name = "Telecommunication" },
            new Industry { Name = "Transportation" },
            new Industry { Name = "Utilities" },
        }
        );
    }
}