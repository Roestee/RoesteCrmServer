using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class CaseOriginConfiguration: IEntityTypeConfiguration<CaseOrigin>
{
    public void Configure(EntityTypeBuilder<CaseOrigin> builder)
    {
        builder.Property(co=>co.Name).IsRequired().HasColumnType("nvarchar(10)");
        builder.HasData(new[]
        {
            new CaseOrigin { Id = Guid.NewGuid(), Name = "Email" },
            new CaseOrigin { Id = Guid.NewGuid(), Name = "Telefon" },
            new CaseOrigin { Id = Guid.NewGuid(), Name = "İnternet" },
        });
    }
}