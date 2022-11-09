using server.Entities.Corporational;
using server.Entities.Users;

namespace server.Services.Users
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
        Task AddNewTherapist(Therapist therapist, int id);
        
        /*
         *  PUT methods
         */
        Task<bool> TherapistExistsAsync(int id);
        
        /*
         *  DELETE methods
         */
        Task DeleteTherapistByIdAsync(int id);
        
        /*
         *  Misc methods
         */
        Task<bool> SaveChangesAsync();
        Task<Corporation> GetCorporationByIdAsync(int id);
    }
}
