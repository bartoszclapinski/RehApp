using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.Personal;

namespace server.Entities.Misc;

public class Address
{
    [Key] [DatabaseGenerated((DatabaseGeneratedOption.Identity))] public int AddressId { get; set; }
    [Required] [MaxLength(100)] public string StreetName { get; set; } = string.Empty;
    [Required] [MaxLength(10)] public string StreetNumber { get; set; } = string.Empty;
    [Required] [MaxLength(50)] public string CityName { get; set; } = string.Empty;
    [Required] [MaxLength(10)] public string CityZipCode { get; set; } = string.Empty;
    [Required] [MaxLength(30)] public string CountryName { get; set; } = string.Empty;

    
}