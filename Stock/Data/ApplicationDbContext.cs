using Microsoft.EntityFrameworkCore;
using Stock.Models;

namespace Stock.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData
                (
                new Category 
                { 
                    Id = 1,
                    Name = "Action",
                    Quantity = 0,
                    AddValue = 0,
                    SubValue = 0,
                    TotalQ = 0
                },
                new Category 
                {
                    Id = 2,
                    Name = "Shop",
                    Quantity = 0,
                    AddValue = 0,
                    SubValue = 0,
                    TotalQ = 0
                },
                new Category
                {
                    Id = 3,
                    Name = "Bis",
                    Quantity = 0,
                    AddValue = 0,
                    SubValue = 0,
                    TotalQ = 0
                }
                );
        }
    }
}
