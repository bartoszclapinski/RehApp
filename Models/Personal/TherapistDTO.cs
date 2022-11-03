using server.Entities.Personal;

namespace server.Models.Personal
{
    public class TherapistDTO
    {
        public int TherapistId { get; set; }
        public string LicenseNumber { get; set; }
        public PersonalDetailsDTO PersonalDetails { get; set; }
    }
}
