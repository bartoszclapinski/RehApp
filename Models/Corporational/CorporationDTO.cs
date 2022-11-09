using server.Entities.Users;
using server.Models.Personal;
using server.Models.Users;

namespace server.Models.Corporational;

public class CorporationDTO
{
    public string CorporationFullName { get; set; }
    public string CorporationTaxNumber { get; set; }
    public AddressDTO Address { get; set; }
}