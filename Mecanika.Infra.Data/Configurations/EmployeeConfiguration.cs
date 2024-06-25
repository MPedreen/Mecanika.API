using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(e => e.Id);
            builder.Property(c => c.IsActive);
            builder.Property(c => c.CreatedAt);
            builder.Property(c => c.UpdatedAt);

            builder.Property(e => e.BirthDate);
            builder.Property(e => e.Gender).IsRequired();
            builder.Property(e => e.JobTitle).HasMaxLength(100).IsRequired();
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
            builder.Property(e => e.EstablishmentId).IsRequired();

            builder.HasOne(e => e.Establishment).WithMany(x => x.Employees).HasForeignKey(e => e.EstablishmentId).IsRequired();
        }
    }
}
