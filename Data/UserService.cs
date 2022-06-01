using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class UserService
{
    private UserDbContext dbContext;

    public UserService(UserDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <summary>
    /// This method returns the list of user
    /// </summary>
    public async Task<List<User>> GetUserAsync()
    {
        return await dbContext.Users.ToListAsync();
    }

    /// <summary>
    /// This method add a new user to the Database
    /// </summary>
    /// <param name="user"></param>
    public async Task AddUserAsync(User user)
    {
        try
        {
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// This method update existing user
    /// </summary>
    /// <param name="user"></param>
    public async Task UpdateUserAsync(User user)
    {
        try
        {
            var isExist = dbContext.Users.FirstOrDefault(q => q.Id == user.Id);
            if (isExist != null)
            {
                dbContext.Users.Update(user);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// This method removes existing user from Database
    /// </summary>
    /// <param name="user"></param>
    public async Task DeleteUserAsync(User user)
    {
        try
        {
            dbContext.Users.Remove(user);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
