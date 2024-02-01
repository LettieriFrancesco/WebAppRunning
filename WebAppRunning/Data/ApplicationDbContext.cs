using Microsoft.EntityFrameworkCore;
using WebAppRunning.Models;

namespace WebAppRunning.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Race> Gare { get; set; }
        public DbSet<Club> Gruppi { get; set; }
        public DbSet<Address> Indirizzi { get; set; }
        public DbSet<State> Stato { get; set; }
        public DbSet<City> Citta { get; set; }
    }
}
