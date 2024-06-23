using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mecanika.Infra.Data.Configurations
{
    public class SupplierConfiguration
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(s => s.Cnpj).HasMaxLength(14).IsRequired();
            builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Phone).HasMaxLength(15).IsRequired();
            builder.Property(s => s.Email).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(200).IsRequired();
            builder.Property(s => s.Number).HasMaxLength(10).IsRequired();
            builder.Property(s => s.Complement).HasMaxLength(50);
            builder.Property(s => s.City).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Uf).HasMaxLength(2).IsRequired();
            builder.Property(s => s.Neighborhood).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Cep).HasMaxLength(9).IsRequired();

            builder.HasMany(s => s.Products).WithOne(p => p.Supplier).HasForeignKey(p => p.SupplierId);
        }
    }
}
