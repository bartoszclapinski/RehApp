using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using server.Entities.Corporational;
using server.Entities.Personal;

namespace server.Entities.Users
{
    public class Therapist
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int TherapistId { get; set; }
        [Required] [MaxLength(20)] public string LicenseNumber { get; set; } = string.Empty;
        [Required] [MaxLength(100)] public string TherapistEmail { get; set; } = string.Empty;
        [Required] [MaxLength(15)] public string TherapistPhoneNumber { get; set; } = string.Empty;
        [Required] [MaxLength(100)] public string TherapistSpecialization { get; set; } = string.Empty;

        public int PersonalDetailsId { get; set; }
        [Required] public PersonalDetails PersonalDetails { get; set; }

        public int CorporationId { get; set; }
        [Required] public Corporation Corporation { get; set; }
    }
}

