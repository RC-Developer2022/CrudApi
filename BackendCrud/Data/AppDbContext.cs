using BackendCrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendCrud.Data;

public class AppDbContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){}
}
