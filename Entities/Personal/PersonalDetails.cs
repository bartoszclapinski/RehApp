using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.Users;

namespace server.Entities.Personal
{
    public class PersonalDetails
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int PersonId { get; set; }
        [Required] [MaxLength(50)] public string FirstName { get; set; } = string.Empty;
        [Required] [MaxLength(50)] public string LastName { get; set; } = string.Empty;
        [Required] [MaxLength(9)] public string NationalNumber { get; set; }

        public int AddressId { get; set; }
        [Required] public Address Address { get; set; }
    }
}
