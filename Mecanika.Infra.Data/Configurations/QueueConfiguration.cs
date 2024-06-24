using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mecanika.Infra.Data.Configurations;
internal class QueueConfiguration : IEntityTypeConfiguration<Queue>
{
    public void Configure(EntityTypeBuilder<Queue> builder)
    {
        builder.ToTable("Queues");
        builder.HasKey(q => q.Id);

        builder.Property(q => q.DateEntry).IsRequired();
        builder.Property(q => q.DepartureDate).IsRequired();
        builder.Property(q => q.QueueNumber).IsRequired();

        builder.HasOne(q => q.Stock)
                .WithOne(s => s.Establishment)
                .HasForeignKey<Establishment>(s => s.StockId);

        //public DateTime DateEntry { get; private set; }
        //public DateTime? DepartureDate { get; private set; }
        //public int QueueNumber { get; private set; }
        //public int ClientId { get; private set; }
        //public virtual Client? Client { get; private set; }
        //public int ServiceId { get; private set; }
        //public virtual Service? Service { get; private set; }
    }
}
