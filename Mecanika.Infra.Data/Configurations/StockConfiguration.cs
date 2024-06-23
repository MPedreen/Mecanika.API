using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.CheckedIn).IsRequired();
            builder.Property(s => s.CheckedOut);
            builder.Property(s => s.EstablishmentId).IsRequired();

            //builder.HasOne(s => s.Establishment).WithOne(e => e.Stock).HasForeignKey<Stock>(s => s.EstablishmentId);
        }
    }
}
