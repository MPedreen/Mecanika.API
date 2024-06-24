using Mecanika.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mecanika.Infra.Data.Context
{
    public class MecanikaDbContext : IdentityDbContext<IdentityUser>
    {
        public MecanikaDbContext(DbContextOptions<MecanikaDbContext> options)
            : base(options)
        { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MecanikaDbContext).Assembly);
        }
    }
}
