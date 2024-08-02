using Microsoft.EntityFrameworkCore;
using Stock.Models;

namespace Stock.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData
                (
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "SciFi" },
                new Category { Id = 3, Name = "History" }
                );
            modelBuilder.Entity<Product>().HasData
                (
                new Product
                {
                    Id = 1,
                    Name = "Pen",
                    Description = "it is a good pen",
                    Price = 50
                },
                new Product
                {
                    Id = 2,
                    Name = "Pensil",
                    Description = "it is a good pen",
                    Price = 50
                },
                new Product
                {
                    Id = 3,
                    Name = "Pepshi",
                    Description = "it is a good pen",
                    Price = 50
                },
                new Product
                {
                    Id = 4,
                    Name = "banana",
                    Description = "it is a good pen",
                    Price = 50
                },
                new Product
                {
                    Id = 5,
                    Name = "mango",
                    Description = "it is a good pen",
                    Price = 50
                },
                new Product
                {
                    Id = 6,
                    Name = "applr",
                    Description = "it is a good pen",
                    Price = 50
                }
                );
        }
    }
}
