using server.Entities.Users;

namespace server.Services.Users;

public interface IPatientRepository
{
    /*
     *  GET methods
     */
    public Task<IEnumerable<Patient>> GetAllPatientsAsync();
    public Task<Patient> GetPatientByIdAsync(int id);
    
    /*
     *  MISC methods
     */
    public Task<bool> PatientExistsAsync(int id);
}