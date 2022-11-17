using server.DbContexts;
using server.Entities.Users;
using Microsoft.EntityFrameworkCore;
using server.Entities.Corporational;

namespace server.Services.Users
{
    public class TherapistsRepository : ITherapistsRepository
    {
        private readonly RehAppDbContext _context;

        public TherapistsRepository(RehAppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /*
         *  Get all Therapists async
         */
        public async Task<IEnumerable<Therapist>> GetAllTherapistsAsync()
        {
            return await _context.Therapists
                .Include(t => t.Corporation)
                .ThenInclude(c => c.Address)
                .Include(t => t.PersonalDetails)
                .ThenInclude(p => p.Address)
                .ToListAsync();
        }

        /*
         *  Get Therapist by Id async
         */
        public async Task<Therapist> GetTherapistByIdAsync(int id)
        {
            return await _context.Therapists
                .Where(t => t.TherapistId == id)
                .Include(t => t.Corporation)
                .ThenInclude(c => c.Address)
                .Include(t => t.PersonalDetails)
                .ThenInclude(p => p.Address)
                .FirstAsync();
        }
        
        /*
         *  Add new therapist async
         */
        public async Task AddNewTherapist(Therapist therapist, int id)
        {
            therapist.Corporation = await _context.Corporations.FirstAsync(c => c.CorporationId == id);
            therapist.CorporationId = id;
            _context.Therapists.Add(therapist);
            await SaveChangesAsync();
        }
        
        /*
         *  Checking if therapist with provided id exists in database
         */
        public async Task<bool> TherapistExistsAsync(int id)
        {
            return await _context.Therapists.AnyAsync(t => t.TherapistId == id);
        }

        /*
         *  Get Corporation by id
         */
        public async Task<Corporation> GetCorporationByIdAsync(int id)
        {
            return await _context.Corporations.FirstAsync(c => c.CorporationId == id);
        }
        
        /*
         *  Delete therapist by id 
         */
        public async Task DeleteTherapistByIdAsync(int id)
        {
            var therapistToRemove = await _context.Therapists
                .Where(t => t.TherapistId == id)
                .Include(t => t.PersonalDetails)
                .ThenInclude(p => p.Address)
                .FirstAsync();

            _context.Addresses.Remove(therapistToRemove.PersonalDetails.Address);
            _context.Persons.Remove(therapistToRemove.PersonalDetails);
            var corporation = await _context.Corporations.Where(c => c.CorporationId == therapistToRemove.CorporationId)
                .FirstAsync();
            corporation.Therapists.Remove(therapistToRemove);
            _context.Therapists.Remove(therapistToRemove);
            await _context.SaveChangesAsync();
        }

        /*
         *  Save database changes
         */
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
