using Microsoft.EntityFrameworkCore;
using SampleLoadBalancing.Models;

namespace SampleLoadBalancing.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Alice" },
            new User { Id = 2, Name = "Bob" },
            new User { Id = 3, Name = "Charlie" }
        );
    }
    
    public DbSet<User> Users { get; set; }
}