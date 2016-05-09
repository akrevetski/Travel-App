using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace ASPNET_intro_new.Models
{
    public class TripContext : DbContext
    {
        public DbSet<Stop> Stops;
        public DbSet<Trip> Trips;

        public TripContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnString = 
                Startup.Configuration["Data:DefaultConnection:TripsConnectionString"];
            optionsBuilder.UseSqlServer(ConnString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
