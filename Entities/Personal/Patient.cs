using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Entities.Personal;

public class Patient
{
    [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int PatientId { get; set; }
    [Required] public DateOnly BirthDate { get; set; }
    
    public int PersonalDetailsId { get; set; }
    [Required] public PersonalDetails PersonalDetails { get; set; }
    
    
    
}