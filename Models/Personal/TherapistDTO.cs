using server.Entities.Personal;

namespace server.Models.Personal
{
    public class TherapistDTO
    {
        public int Id { get; set; }
        public Person personalDetails { get; set; }
    }
}
