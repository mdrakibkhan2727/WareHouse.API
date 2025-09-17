using Microsoft.EntityFrameworkCore;
using WareHouse.Data.Models;

namespace WareHouse.Data.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Warehouse> Warehouses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Warehouse)
                .WithMany(w => w.Products)
                .HasForeignKey(p => p.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.SKU)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Quantity)
                .IsRequired();

            modelBuilder.Entity<Warehouse>()
                .Property(w => w.Name)
                .IsRequired();
        }
    }
}
