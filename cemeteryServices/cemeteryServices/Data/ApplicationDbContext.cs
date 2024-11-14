using Microsoft.EntityFrameworkCore;
using cemeteryServices.Models;

namespace cemeteryServices.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sample Product 1", Description = "Description for product 1", Price = 9.99m, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 2, Name = "Sample Product 2", Description = "Description for product 2", Price = 19.99m, ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 3, Name = "Sample Product 3", Description = "Description for product 3", Price = 29.99m, ImageUrl = "https://via.placeholder.com/150" }
            );
        }
    }
}
