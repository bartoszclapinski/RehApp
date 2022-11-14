using Microsoft.AspNetCore.Mvc;
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

    public async Task<Patient> GetPatientByIdAsync(int id)
    {
        return await _context.Patients
            .Include(p => p.PersonalDetails)
            .ThenInclude(pd => pd.Address)
            .Include(p => p.Corporation)
            .ThenInclude(c => c.Address)
            .Include(p => p.Therapist)
            .FirstAsync();
    }

    public async Task AddNewPatientAsync(Patient patient, int corporationId)
    {
        patient.Corporation = await _context.Corporations.FirstAsync(c => c.CorporationId == corporationId);
        patient.CorporationId = corporationId;
        _context.Persons.Add(patient.PersonalDetails);
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> PatientExistsAsync(int id)
    {
        return (await _context.Patients.AnyAsync(p => p.PatientId == id));
    }
}