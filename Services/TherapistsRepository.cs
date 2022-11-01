using server.DbContexts;
using server.Entities.Personal;
using Microsoft.EntityFrameworkCore;

namespace server.Services
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
            return await _context.Therapists.ToListAsync();
        }

        /*
         *  Get Therapist by Id async
         */
        public async Task<Therapist> GetTherapistByIdAsync(int id)
        {
            return await _context.Therapists.Where(t => t.TherapistId == id).FirstAsync();
        }

        public async Task AddNewTherapist(Therapist therapist)
        {
            _context.Therapists.Add(therapist);
            await SaveChangesAsync();
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
