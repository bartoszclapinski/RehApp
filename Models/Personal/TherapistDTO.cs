using server.Entities.Corporations;
using server.Entities.Personal;
using server.Models.Corporational;

namespace server.Models.Personal
{
    public class TherapistDTO
    {
        public int TherapistId { get; set; }
        public string LicenseNumber { get; set; }
        public PersonalDetailsDTO PersonalDetails { get; set; }
        public CorporationDTO Corporation { get; set; }
    }
}
