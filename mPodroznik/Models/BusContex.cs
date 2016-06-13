using mPodroznik.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPodroznik.Models
{
    public class BusContex : DbContext
    {
        public BusContex() : base("BusContext")
        {
            Database.SetInitializer<BusContex>(new BusInitializer());
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusStop> BusStops { get; set; }
    }
}
