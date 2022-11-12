using server.Entities.Corporational;

namespace server.Services.Corporational;

public interface ICorporationRepository
{
    /*
     *  GET methods
     */
    Task<IEnumerable<Corporation>> GetAllCorporationsAsync();
    Task<Corporation> GetCorporationByIdAsync(int id);
    
    /*
     *  POST methods
     */
    Task AddNewCorporation(Corporation corporation);

    /*
     *  PUT methods
     */
    Task<bool> CorporationExistsAsync(int id);
    
    /*
     *  MISC methods
     */
    Task<bool> SaveChangesAsync();
}