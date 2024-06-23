using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    public class EstablishmentConfiguration : IEntityTypeConfiguration<Establishment>
    {
        public void Configure(EntityTypeBuilder<Establishment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Cnpj).HasMaxLength(18).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Number).HasMaxLength(10).IsRequired();
            builder.Property(e => e.Complement).HasMaxLength(50);
            builder.Property(e => e.City).HasMaxLength(100).IsRequired();
            builder.Property(e => e.UF).HasMaxLength(2).IsRequired();
            builder.Property(e => e.Nighborhood).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Cep).HasMaxLength(9).IsRequired();
            builder.Property(e => e.StockId);

            //builder.HasOne(e => e.Stock).WithOne(s => s.Establishment).HasForeignKey<Stock>(s => s.EstablishmentId);

            builder.HasMany(e => e.Employees).WithOne(emp => emp.Establishment).HasForeignKey(emp => emp.EstablishmentId);
        }
    }
}
