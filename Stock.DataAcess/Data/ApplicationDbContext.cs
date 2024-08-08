using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stock.Models;

namespace Stock.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData
                (
                new Category { Id = 1001, Name = "Action" },
                new Category { Id = 1002, Name = "SciFi" },
                new Category { Id = 1003, Name = "History" }
                );
            modelBuilder.Entity<Product>().HasData
                (
                new Product
                {
                    Id = 101,
                    Name = "Pen",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1001,
                    ImageUrl =""
                },
                new Product
                {
                    Id = 102,
                    Name = "Pensil",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1002,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 103,
                    Name = "Pepshi",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1001,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 104,
                    Name = "banana",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1002,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 105,
                    Name = "mango",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1003,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 106,
                    Name = "applr",
                    Description = "it is a good pen",
                    Price = 50,
                    CategoryId = 1003,
                    ImageUrl = ""
                }
                );
        }
    }
}
