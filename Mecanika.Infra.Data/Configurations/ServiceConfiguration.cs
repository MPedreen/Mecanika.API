using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(s => s.Id);
            builder.Property(c => c.IsActive);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.UpdatedAt);

            builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(200).IsRequired();
            builder.Property(s => s.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(s => s.Duration).HasPrecision(5, 2).IsRequired();

            builder.HasMany(s => s.Schedulings).WithOne(sch => sch.Service).HasForeignKey(sch => sch.ServiceId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasMany(s => s.Queues).WithOne(q => q.Service).HasForeignKey(q => q.ServiceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
