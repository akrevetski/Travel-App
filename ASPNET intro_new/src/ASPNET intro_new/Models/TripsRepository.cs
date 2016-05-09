using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC6.Models;
using ASPNET_intro_new.Models;
using System.Collections;

namespace ASPNET_intro_new.Models
{
    public class TripsRepository : DbContext
    {
        private DbSet<Trip> Trips { get; set; }

        public TripsRepository(DbSet<Trip> theTrips)
        {
            theTrips = Trips;
        }

        public IEnumerable GetAllTrips()
        {
            return new List<Trip>();
        }

        public Trip GetTrip(Trip t)
        {
            return t;
        }
    }
}
