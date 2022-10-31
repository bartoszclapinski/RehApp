using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Entities.Personal
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; } 
        
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public ICollection<Therapist> Therapists { get; set; }
    }
}
