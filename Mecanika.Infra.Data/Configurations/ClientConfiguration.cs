using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(t => t.Id);

            builder.Property(c => c.IsActive);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.UpdatedAt);

            builder.Property(c => c.Gender).IsRequired();
            builder.Property(c => c.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(c => c.BirthDate).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(15).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Address).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Number).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Complement).HasMaxLength(50);
            builder.Property(c => c.City).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Uf).HasMaxLength(2).IsRequired();
            builder.Property(c => c.Neighborhood).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Cep).HasMaxLength(9).IsRequired();

            builder.HasMany(c => c.Vehicles).WithOne(v => v.Client).HasForeignKey(v => v.ClientId);
        }
    }
}
