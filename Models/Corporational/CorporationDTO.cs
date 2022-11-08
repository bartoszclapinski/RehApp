using server.Models.Personal;

namespace server.Models.Corporational;

public class CorporationDTO
{
    public string CorporationFullName { get; set; }
    public string CorporationTaxNumber { get; set; }
    public AddressDTO Address { get; set; }
}