using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Entities.Personal
{
    public class Therapist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TherapistId { get; set; }

        [Required]
        [MaxLength(20)]
        public string LicenseNumber { get; set; }
        
        [Required]
        public PersonalDetails PersonalDetails { get; set; }
        
        [Required]
        public int PersonalDetailsId { get; set; }
    }
}
