﻿using Mecanika.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Configurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.VehicleLicensePlate).HasMaxLength(10).IsRequired();
            builder.Property(v => v.Model).HasMaxLength(100).IsRequired();
            builder.Property(v => v.Brand).HasMaxLength(50).IsRequired();
            builder.Property(v => v.Year).IsRequired();
            builder.Property(v => v.Color).HasMaxLength(30);
            builder.Property(v => v.TypeVehicle).HasMaxLength(50);
            builder.Property(v => v.ClientId).IsRequired();

            builder.HasOne(v => v.Client).WithMany(c => c.Vehicles).HasForeignKey(v => v.ClientId).IsRequired();
        }
    }
}
