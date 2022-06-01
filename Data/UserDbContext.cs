using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
#if DEBUG
        modelBuilder.Entity<User>().HasData(new List<User>
        {
            new User { Id = 1200, Name = "name1", Biography = "bio1" },
            new User { Id = 1201, Name = "name2", Biography = "bio2" },
            new User { Id = 1202, Name = "name3", Biography = "bio3" }
        });
#endif
        base.OnModelCreating(modelBuilder);
    }
}