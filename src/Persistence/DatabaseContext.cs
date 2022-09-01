using Microsoft.EntityFrameworkCore;
using src.Models;
namespace src.Persistence;

public class DatabaseContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<Contrato> Contratos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pessoa>(e =>
        {
            e.HasKey(e => e.Id);
            e
            .HasMany(e => e.contratos) // relacionamento  tabelas 1 p/ muitos
            .WithOne()
            .HasForeignKey(c => c.PessoaId);
        });

        builder.Entity<Contrato>(e =>
        {
            e.HasKey(e => e.Id);
        });
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) :
    base(options)
    {

    }

}