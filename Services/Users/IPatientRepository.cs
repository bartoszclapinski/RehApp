using server.Entities.Corporational;
using server.Entities.Users;

namespace server.Services.Users;

public interface IPatientRepository
{
    /*
     *  GET methods
     */
    public Task<IEnumerable<Patient>> GetAllPatientsAsync ();
    public Task<Patient> GetPatientByIdAsync (int id);
    
    /*
     *  POST methods 
     */
    Task AddNewPatientAsync (Patient patient, int corporationId);

    /*
     *  MISC methods
     */
    public Task<bool> PatientExistsAsync (int id);
}