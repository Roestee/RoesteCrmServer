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
            new Account { Name = "Müşteri" },
            new Account { Name = "Analist" },
            new Account { Name = "Yarışmacı" },
            new Account { Name = "Entegratör" },
            new Account { Name = "Yatırımcı" },
            new Account { Name = "Basın" },
            new Account { Name = "Bayi" },
            new Account { Name = "Ortak" },
            new Account { Name = "Diğer" },
        });
    }
}