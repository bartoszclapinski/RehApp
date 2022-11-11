using server.Models.Personal;

namespace server.Models.Users;

public class PatientDTO
{
    public PersonalDetailsDTO PersonalDetials { get; set; }
    public DateTime PatientBirthDate { get; set; }
    public string PatientDiseaseEntity { get; set; }
    public DateTime PatientJoinDate { get; set; }
    public bool PatientTravel { get; set; }
    public string PatientCareGiver { get; set; }
}