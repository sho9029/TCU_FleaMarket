using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new List<User>
        {
            new User { Id = 1, Name = "ユーザー1", Biography = "自己紹介" },
        });
        base.OnModelCreating(modelBuilder);
    }
}