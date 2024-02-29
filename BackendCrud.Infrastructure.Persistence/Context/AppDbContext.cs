using Backend.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendCrud.Data;

public class AppDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
