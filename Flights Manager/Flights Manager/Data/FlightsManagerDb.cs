using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FlightsManagerDb : DbContext
    {
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-4RLM30D\SQLEXPRESS; Database=FlightsManagerDb; Integrated security = True; Connection Timeout = 30;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
