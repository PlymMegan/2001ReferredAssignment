using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class ApplicationDbContext : DbContext
{
    // Define your tables as DbSets
    public DbSet<YourEntity> YourEntities { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Configure the model with Fluent API if needed
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

public class YourEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Other properties
}
