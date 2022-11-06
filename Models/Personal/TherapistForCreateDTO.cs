using server.Entities.Personal;
using server.Models.Corporational;

namespace server.Models.Personal;

public class TherapistForCreateDTO {

    public PersonalDetailsForCreateDTO PersonalDetails { get; set; }
    public string LicenseNumber { get; set; }
    public CorporationDTO Corporation { get; set; }
}