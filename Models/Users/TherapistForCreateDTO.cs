using server.Models.Personal;

namespace server.Models.Users;

public class TherapistForCreateDTO {

    public PersonalDetailsForCreateDTO PersonalDetails { get; set; }
    public string LicenseNumber { get; set; }
}