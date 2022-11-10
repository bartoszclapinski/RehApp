using server.Models.Personal;

namespace server.Models.Users;

public class TherapistForCreateDTO {

    public string LicenseNumber { get; set; }
    public string TherapistEmail { get; set; }
    public string TherapistPhoneNumber { get; set; }
    public string TherapistSpecialization { get; set; }
    
    public PersonalDetailsForCreateDTO PersonalDetails { get; set; }
    
    
}