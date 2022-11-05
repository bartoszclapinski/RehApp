using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.Misc;

namespace server.Entities.Personal
{
    public class PersonalDetails
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int PersonId { get; set; }
        [Required] [MaxLength(50)] public string FirstName { get; set; } = string.Empty;
        [Required] [MaxLength(50)] public string LastName { get; set; } = string.Empty;

        public int AddressId { get; set; }
        public Address Address { get; set; }
        
        public ICollection<Therapist> Therapists { get; set; }
    }
}
