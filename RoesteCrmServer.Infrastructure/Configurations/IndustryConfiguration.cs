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
            new Industry { Id = Guid.NewGuid(), Name = "Tarım" },
            new Industry { Id = Guid.NewGuid(), Name = "Tekstil" },
            new Industry { Id = Guid.NewGuid(), Name = "Banka" },
            new Industry { Id = Guid.NewGuid(), Name = "Biyoteknoloji" },
            new Industry { Id = Guid.NewGuid(), Name = "Kimya" },
            new Industry { Id = Guid.NewGuid(), Name = "İletişim" },
            new Industry { Id = Guid.NewGuid(), Name = "İnşaat" },
            new Industry { Id = Guid.NewGuid(), Name = "Danışmanlık" },
            new Industry { Id = Guid.NewGuid(), Name = "Eğitim" },
            new Industry { Id = Guid.NewGuid(), Name = "Elektronik" },
            new Industry { Id = Guid.NewGuid(), Name = "Enerji" },
            new Industry { Id = Guid.NewGuid(), Name = "Mühendislik" },
            new Industry { Id = Guid.NewGuid(), Name = "Eğlence" },
            new Industry { Id = Guid.NewGuid(), Name = "Çevre" },
            new Industry { Id = Guid.NewGuid(), Name = "Finans" },
            new Industry { Id = Guid.NewGuid(), Name = "Yiyecek ve İçecek" },
            new Industry { Id = Guid.NewGuid(), Name = "Devlet" },
            new Industry { Id = Guid.NewGuid(), Name = "Sağlık Hizmeti" },
            new Industry { Id = Guid.NewGuid(), Name = "Hastane" },
            new Industry { Id = Guid.NewGuid(), Name = "Sigorta" },
            new Industry { Id = Guid.NewGuid(), Name = "Üretim" },
            new Industry { Id = Guid.NewGuid(), Name = "Medya" },
            new Industry { Id = Guid.NewGuid(), Name = "Kar Amaçlı Değil" },
            new Industry { Id = Guid.NewGuid(), Name = "Diğer" },
            new Industry { Id = Guid.NewGuid(), Name = "Nakliye" },
            new Industry { Id = Guid.NewGuid(), Name = "Telekomünikasyon" },
            new Industry { Id = Guid.NewGuid(), Name = "Ulaşım" },
            new Industry { Id = Guid.NewGuid(), Name = "Kamu Kuruluşları" },
        }
        );
    }
}