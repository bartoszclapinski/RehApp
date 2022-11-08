using server.Models.Corporational;
using server.Models.Personal;

namespace server.Models.Users
{
    public class TherapistDTO
    {
        public int TherapistId { get; set; }
        public string LicenseNumber { get; set; }
        public PersonalDetailsDTO PersonalDetails { get; set; }
        public CorporationDTO Corporation { get; set; }
    }
}
