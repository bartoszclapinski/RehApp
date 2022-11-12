using Microsoft.EntityFrameworkCore;
using server.DbContexts;
using server.Entities.Corporational;

namespace server.Services.Corporational;

public class CorporationRepository : ICorporationRepository
{
    private readonly RehAppDbContext _context;
    private ICorporationRepository _corporationRepositoryImplementation;

    public CorporationRepository(RehAppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    /*
     *  Get all corporations
     */
    public async Task<IEnumerable<Corporation>> GetAllCorporationsAsync()
    {
        return await _context.Corporations
            .Include(c => c.Address)
            .Include(c => c.Therapists)
            .ToListAsync();
    }

    public async Task<Corporation> GetCorporationByIdAsync(int id)
    {
        return await _context.Corporations
            .Where(c => c.CorporationId == id)
            .Include(c => c.Address)
            .Include(c => c.Therapists)
            .FirstAsync();
    }

    public async Task AddNewCorporation(Corporation corporation) 
    {
        _context.Corporations.Add(corporation);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> CorporationExistsAsync(int id)
    {
        return await _context.Corporations.AnyAsync(c => c.CorporationId == id);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync() >= 0);
    }
}