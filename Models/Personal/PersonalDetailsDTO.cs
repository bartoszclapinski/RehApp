namespace server.Models.Personal;

public class PersonalDetailsDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalNumber { get; set; }
    public AddressDTO Address { get; set; }
}