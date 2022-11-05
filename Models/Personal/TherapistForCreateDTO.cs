using server.Entities.Personal;

namespace server.Models.Personal;

public class TherapistForCreateDTO {

    public PersonalDetailsForCreateDTO PersonalDetails { get; set; }

    public string LicenseNumber { get; set; }
}