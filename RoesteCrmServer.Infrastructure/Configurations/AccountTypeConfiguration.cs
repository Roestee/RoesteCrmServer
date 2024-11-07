using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoesteCrmServer.Domain.Entities;

namespace RoesteCrmServer.Infrastructure.Configurations;

public class AccountTypeConfiguration: IEntityTypeConfiguration<AccountType>
{
    public void Configure(EntityTypeBuilder<AccountType> builder)
    {
        builder.Property(a => a.Name).IsRequired().HasColumnType("nvarchar(20)");
        builder.HasData(new[]
        {
            new AccountType { Id = Guid.NewGuid(), Name = "Müşteri" },
            new AccountType { Id = Guid.NewGuid(), Name = "Analist" },
            new AccountType { Id = Guid.NewGuid(), Name = "Yarışmacı" },
            new AccountType { Id = Guid.NewGuid(), Name = "Entegratör" },
            new AccountType { Id = Guid.NewGuid(), Name = "Yatırımcı" },
            new AccountType { Id = Guid.NewGuid(), Name = "Basın" },
            new AccountType { Id = Guid.NewGuid(), Name = "Bayi" },
            new AccountType { Id = Guid.NewGuid(), Name = "Ortak" },
            new AccountType { Id = Guid.NewGuid(), Name = "Diğer" },
        });
    }
}