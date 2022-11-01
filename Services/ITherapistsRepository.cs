using server.Entities.Personal;

namespace server.Services
{
    public interface ITherapistsRepository
    {        
        /*
         *  GET methods
         */
        Task<IEnumerable<Therapist>> GetAllTherapistsAsync();
        Task<Therapist> GetTherapistByIdAsync(int id);
        
        /*
         *  Add methods
         */
        Task AddNewTherapist(Therapist therapist);
        
        Task<bool> SaveChangesAsync();
    }
}
