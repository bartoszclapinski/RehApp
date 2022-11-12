using server.Entities.Users;

namespace server.Services.Users;

public interface IPatientRepository
{
    /*
     *  GET methods
     */
    public Task<IEnumerable<Patient>> GetAllPatientsAsync();
}