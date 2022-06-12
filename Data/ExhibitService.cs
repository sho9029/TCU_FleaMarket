using Microsoft.EntityFrameworkCore;
namespace TCU_FleaMarket.Data;

public class ExhibitService
{
    private ExhibitDbContext dbContext;

    public ExhibitService(ExhibitDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <summary>
    /// This method returns the list of exhibit
    /// </summary>
    public async Task<List<Exhibit>> GetExhibitAsync()
    {
        try
        {
            return await dbContext.Exhibits.ToListAsync();
        }
        catch (ArgumentNullException)
        {
            throw;
        }
    }

    /// <summary>
    /// This method add a new exhibit to the Database
    /// </summary>
    /// <param name="exhibit"></param>
    public async Task AddExhibitAsync(Exhibit exhibit)
    {
        try
        {
            dbContext.Exhibits.Add(exhibit);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// This method update existing exhibit
    /// </summary>
    /// <param name="exhibit"></param>
    public async Task UpdateExhibitAsync(Exhibit exhibit)
    {
        try
        {
            var isExist = dbContext.Exhibits.FirstOrDefault(x => x.Id == exhibit.Id);
            if (isExist != null)
            {
                dbContext.Exhibits.Update(exhibit);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// This method removes existing exhibit from Database
    /// </summary>
    /// <param name="exhibit"></param>
    public async Task DeleteExhibitAsync(Exhibit exhibit)
    {
        try
        {
            dbContext.Exhibits.Remove(exhibit);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
