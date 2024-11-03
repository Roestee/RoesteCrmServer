using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class CaseStatusConfiguration: IEntityTypeConfiguration<CaseStatus>
{
    public void Configure(EntityTypeBuilder<CaseStatus> builder)
    {
        builder.Property(cs=> cs.Name).IsRequired().HasColumnType("nvarchar(20)");
        builder.HasData(new[]
        {
            new CaseStatus { Id= Guid.NewGuid(), Name = "Yeni" },
            new CaseStatus { Id= Guid.NewGuid(), Name = "Hazırlık" },
            new CaseStatus { Id= Guid.NewGuid(), Name = "Müşteri Bekleniyor" },
            new CaseStatus { Id= Guid.NewGuid(), Name = "İlerletildi" },
            new CaseStatus { Id= Guid.NewGuid(), Name = "Kapandı" },
        });
    }
}