using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class FlightManagerDbContext : DbContext
    {
        public FlightManagerDbContext() : base()
        {
            
        }

        public FlightManagerDbContext(DbContextOptions options) : base(options) 
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server = DESKTOP-AJB39SI\SQLEXPRESS ;Database=FlightsManagerDb;Trusted_Connection=True;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasOne(re => re.User).WithOne(c => c.Reservation);

            modelBuilder.Entity<Reservation>().HasOne(re => re.Flight).WithOne(c => c.Reservation);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Reservation> Reservations { get; set;}
        public DbSet<Flight> Flights { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
