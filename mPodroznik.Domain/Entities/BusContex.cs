using mPodroznik.Domain.DAL;
using System.Data.Entity;

namespace mPodroznik.Domain.Entities
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
