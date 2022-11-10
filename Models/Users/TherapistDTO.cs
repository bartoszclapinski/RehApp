using server.Models.Corporational;
using server.Models.Personal;

namespace server.Models.Users
{
    public class TherapistDTO
    {
        public int TherapistId { get; set; }
        public string LicenseNumber { get; set; }
        public string TherapistEmail { get; set; }
        public string TherapistPhoneNumber { get; set; }
        public string TherapistSpecialization { get; set; }
        
        public PersonalDetailsDTO PersonalDetails { get; set; }
        public CorporationDTO Corporation { get; set; }
    }
}
