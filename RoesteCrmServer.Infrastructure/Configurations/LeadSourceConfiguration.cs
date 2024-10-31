using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class LeadSourceConfiguration: IEntityTypeConfiguration<LeadSource>
{
    public void Configure(EntityTypeBuilder<LeadSource> builder)
    {
        builder.Property(ls=> ls.Name).IsRequired().HasColumnType("nvarchar(50)");
        builder.HasData(
            new LeadSource{Name = "Advertisement"}, 
            new LeadSource{Name = "Employee Referral"},
            new LeadSource{Name = "External Referral"},
            new LeadSource{Name = "In-Store"},
            new LeadSource{Name = "On Site"},
            new LeadSource{Name = "Social"},
            new LeadSource{Name = "Trade Show"},
            new LeadSource{Name = "Web"}, 
            new LeadSource{Name = "Word of mouth"},
            new LeadSource{Name = "Other"});
    }
}