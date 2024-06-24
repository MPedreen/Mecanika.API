using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    internal class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(c => c.IsActive);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.UpdatedAt);

            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.CheckedIn).IsRequired();
            builder.Property(s => s.CheckedOut);

            builder
                .HasOne(s => s.Establishment)
                .WithOne(e => e.Stock)
                .HasForeignKey<Stock>(s => s.EstablishmentId);
        }
    }
}
