namespace server.Models.Personal;

public class PersonalDetailsForCreateDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalNumber { get; set; }
    public AddressDTO Address { get; set; }
}