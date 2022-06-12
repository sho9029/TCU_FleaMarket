using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class ExhibitDbContext : DbContext
{
    public ExhibitDbContext(DbContextOptions<ExhibitDbContext> optinos)
        : base(optinos)
    {
        Database.EnsureCreated();
    }

    public DbSet<Exhibit> Exhibits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exhibit>().HasData(new List<Exhibit>
        {
        });
        base.OnModelCreating(modelBuilder);
    }
}
