using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DotnetRoomReservation.Models;

namespace DotnetRoomReservation.Database;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = optionsBuilder.Options.FindExtension<CoreOptionsExtension>()?.ApplicationServiceProvider?.GetService<IConfiguration>();

            if (configuration == null)
            {
                throw new Exception("Arquivo de configuração não encontrado.");
            }

            optionsBuilder.UseSqlite(_configuration.GetConnectionString("SQLiteConnection"));
        }
    }


    public DbSet<Administrador> Administradores { get; set; }
}
