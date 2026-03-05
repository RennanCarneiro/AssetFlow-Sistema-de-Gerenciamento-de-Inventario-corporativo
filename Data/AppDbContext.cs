using Microsoft.EntityFrameworkCore;
using AssetFlow.Api.Models;

namespace AssetFlow.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Essa linha diz ao EF para criar uma tabela chamada 'Assets' baseada na Model
    public DbSet<Asset> Assets { get; set; }
}