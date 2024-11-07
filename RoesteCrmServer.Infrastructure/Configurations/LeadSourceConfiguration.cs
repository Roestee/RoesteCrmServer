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
            new LeadSource{ Id = Guid.NewGuid(), Name = "Reklamlar"}, 
            new LeadSource{ Id = Guid.NewGuid(), Name = "Çalışan Tavsiyesi"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "Dışarıdan Tavsiye"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "Pankart"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "Sosyal Medya"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "TV"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "İnternet"}, 
            new LeadSource{ Id = Guid.NewGuid(), Name = "Sözlü Olarak"},
            new LeadSource{ Id = Guid.NewGuid(), Name = "Diğer"});
    }
}