using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class LeadStatusConfiguration: IEntityTypeConfiguration<LeadStatus>
{
    public void Configure(EntityTypeBuilder<LeadStatus> builder)
    {
        builder.Property(l=>l.Name).IsRequired().HasColumnType("nvarchar(30)");
        builder.HasData(
            new LeadStatus {Id= Guid.NewGuid(), Name = "Yeni" },
            new LeadStatus {Id= Guid.NewGuid(), Name = "İletişime Geçildi" },
            new LeadStatus {Id= Guid.NewGuid(), Name = "Süreç İlerliyor" }, 
            new LeadStatus {Id= Guid.NewGuid(), Name = "Niteliksiz" },
            new LeadStatus { Id = Guid.NewGuid(), Name = "Dönüştür" });
    }
}