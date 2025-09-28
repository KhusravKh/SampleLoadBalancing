using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Banana" },
            new Product { Id = 2, Name = "Apple" },
            new Product { Id = 3, Name = "Cherry" }
        );
    }
    
    public DbSet<Product> Products { get; set; }
}