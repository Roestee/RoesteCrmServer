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
            new LeadStatus { Name = "New" },
            new LeadStatus { Name = "Contacted" },
            new LeadStatus { Name = "Working" }, 
            new LeadStatus { Name = "Qualified" },
            new LeadStatus { Name = "Unqualified" });
    }
}