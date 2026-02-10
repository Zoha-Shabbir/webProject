using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMvcAuthProject.Models;

namespace MyMvcAuthProject.Data;

public class ApplicationDbContext : IdentityDbContext<MyApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed initial data
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Laptop",
                Description = "High-performance laptop for development",
                Price = 999.99m,
                Quantity = 15,
                CreatedDate = DateTime.UtcNow,
                Category = "Electronics",
                IsActive = true
            },
            new Product
            {
                ProductId = 2,
                Name = "Wireless Mouse",
                Description = "Ergonomic wireless mouse",
                Price = 29.99m,
                Quantity = 50,
                CreatedDate = DateTime.UtcNow,
                Category = "Accessories",
                IsActive = true
            },
            new Product
            {
                ProductId = 3,
                Name = "USB-C Cable",
                Description = "High-speed USB-C charging cable",
                Price = 14.99m,
                Quantity = 100,
                CreatedDate = DateTime.UtcNow,
                Category = "Cables",
                IsActive = true
            },
            new Product
            {
                ProductId = 4,
                Name = "Mechanical Keyboard",
                Description = "RGB mechanical keyboard with switches",
                Price = 129.99m,
                Quantity = 25,
                CreatedDate = DateTime.UtcNow,
                Category = "Accessories",
                IsActive = true
            }
        );
    }
}
