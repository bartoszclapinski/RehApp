using Microsoft.EntityFrameworkCore;
using server.Entities.Personal;
using Microsoft.Extensions.Configuration;

namespace server.DbContexts
{
    public class RehAppDbContext : DbContext
    {
        private IConfiguration _configuration;
        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Therapist> Therapists { get; set; }

        public RehAppDbContext(DbContextOptions<RehAppDbContext> options) : base(options) {}

    }
}
