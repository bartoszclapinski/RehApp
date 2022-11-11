using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.Corporational;
using server.Entities.Personal;

namespace server.Entities.Users;

public class Patient
{
    [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int PatientId { get; set; }
    [Required] public DateTime PatientBirthDate { get; set; }
    [Required] public string PatientDiseaseEntity { get; set; } = string.Empty;
    [Required] public DateTime PatientJoinDate { get; set; }
    [Required] public bool PatientTravel { get; set; }
    public string PatientCareGiver { get; set; } = string.Empty;
    
    public int PersonalDetailsId { get; set; }
    [Required] public PersonalDetails PersonalDetails { get; set; }

    public int TherapistId { get; set; }
    [Required] public Therapist Therapist { get; set; }
    
    public int CorporationId { get; set; }
    [Required] public Corporation Corporation { get; set; }
} 