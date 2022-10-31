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
        public Person PersonalDetails { get; set; }

    }
}
