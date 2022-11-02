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
         *  POST methods
         */
        Task AddNewTherapist(Therapist therapist);
        
        /*
         *  PUT methods
         */
        Task<bool> TherapistExistsAsync(int id);
        
        Task<bool> SaveChangesAsync();
    }
}
