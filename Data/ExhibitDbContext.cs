using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class ExhibitDbContext : DbContext
{
    public ExhibitDbContext(DbContextOptions<ExhibitDbContext> optinos)
        : base(optinos)
    {
    }

    public DbSet<Exhibit> Exhibits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
#if DEBUG
        modelBuilder.Entity<Exhibit>().HasData(new List<Exhibit>
        {
            new Exhibit { Id = 1, ExhibitorsId = 1200, Name = "ex1", Description = "desc1" },
            new Exhibit { Id = 2, ExhibitorsId = 1201, Name = "ex2", Description = "desc2" },
            new Exhibit { Id = 3, ExhibitorsId = 1202, Name = "ex3", Description = "desc3" }
        });
#endif
        base.OnModelCreating(modelBuilder);
    }
}
