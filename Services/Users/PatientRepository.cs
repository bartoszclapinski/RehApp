using Microsoft.EntityFrameworkCore;
using server.DbContexts;
using server.Entities.Users;

namespace server.Services.Users;

public class PatientRepository : IPatientRepository
{
    private readonly RehAppDbContext _context;

    public PatientRepository(RehAppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
    {
        return await _context.Patients
            .Include(p => p.PersonalDetails)
            .ThenInclude(pd => pd.Address)
            .Include(p => p.Corporation)
            .ThenInclude(c => c.Address)
            .Include(p => p.Therapist)
            .ToListAsync();
    }
}