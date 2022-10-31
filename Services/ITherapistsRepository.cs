using server.Entities.Personal;

namespace server.Services
{
    public interface ITherapistsRepository
    {        
        Task<IEnumerable<Therapist>> GetAllTherapistsAsync();
        Task<Therapist> GetTherapistByIdAsync(int id);
    }
}
