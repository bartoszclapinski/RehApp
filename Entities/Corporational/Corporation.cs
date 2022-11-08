using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using server.Entities.Personal;
using server.Entities.Users;

namespace server.Entities.Corporational;

public class Corporation
{
    [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int CorporationId { get; set; }
    [Required] [MaxLength(200)] public string CorporationFullName { get; set; } = string.Empty;
    [Required] [MaxLength(20)] public string CorporationTaxNumber { get; set; } = string.Empty;

    public int AddressId { get; set; }
    [Required] public Address Address { get; set; }

    public ICollection<Therapist> Therapists { get; set; }
}