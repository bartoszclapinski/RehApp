using Microsoft.EntityFrameworkCore;
using server.Entities.Personal;
using server.Entities.Corporational;
using server.Entities.Users;
namespace server.DbContexts
{
    public class RehAppDbContext : DbContext
    {
        private IConfiguration _configuration;
        
        public DbSet<PersonalDetails> Persons { get; set; }
        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Corporation> Corporations { get; set; }

        public RehAppDbContext(DbContextOptions<RehAppDbContext> options) : base(options) {}

    }
}
