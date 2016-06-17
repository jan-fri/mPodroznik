using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using mPodroznik.Domain.Entities;

namespace mPodroznik.Domain.DAL
{
    public class BusInitializer : DropCreateDatabaseIfModelChanges<BusContex>
    {
        protected override void Seed(BusContex context)
        {
            // base.Seed(context);
            var buses = new List<Bus>
            {
               new Bus {BusNumber = "1" },
               new Bus {BusNumber= "2" }
            };

            buses.ForEach(b => context.Buses.Add(b));
            context.SaveChanges();

            var busStops = new List<BusStop>
            {
                new BusStop {Name = "Cygański Las", BusID = 1, GPSLat=49.79078, GPSLong = 19.04916},
                new BusStop {Name = "Bystrzańska Olszówka", BusID = 1, GPSLat=49.79555, GPSLong=19.05182},
                new BusStop {Name = "Długa Zajezdnia MZK", BusID = 1, GPSLat=49.7926, GPSLong=19.0466},
                new BusStop {Name = "Armii Krajowej Szpital", BusID = 1, GPSLat=49.79424, GPSLong=19.038},
                new BusStop {Name = "Partyzantów Folwark", BusID = 1, GPSLat=49.80317, GPSLong=19.04563 },
                new BusStop {Name = "Partyzantów Apena", BusID = 1, GPSLat=49.80875, GPSLong=19.04265 },
                new BusStop {Name = "Plac Mickiewicza", BusID = 1, GPSLat=49.81498, GPSLong=19.0448 },
                new BusStop {Name = "Plac Żwirki i Wigury", BusID = 1, GPSLat=49.81844, GPSLong=19.04407},
                new BusStop {Name = "Hotel Prezydent", BusID = 1, GPSLat=49.8233, GPSLong=19.04511},
                new BusStop {Name = "3 Maja Dworzec", BusID = 1, GPSLat=49.8278, GPSLong=19.04501 },
                new BusStop {Name = "Piastowska Lubertowicza", BusID = 1, GPSLat=49.8268, GPSLong=19.03617 },
                new BusStop {Name = "Piastowska Wita Stwosza", BusID = 1, GPSLat=49.82472, GPSLong=19.02999},
                new BusStop {Name = "Piastowska Sobieskiego", BusID = 1, GPSLat=49.82115, GPSLong=19.02429 },
                new BusStop {Name = "Cieszyńska Hulanka", BusID = 1, GPSLat=49.81387, GPSLong=19.01802},
                new BusStop {Name = "Szarotki Cieszyńska", BusID = 1, GPSLat=49.81174, GPSLong=19.01227 },
                new BusStop {Name = "Szarotki SAM", BusID = 1, GPSLat=49.80894, GPSLong=19.01738},

                new BusStop {Name = "Mikuszowice Stalownik", BusID = 2, GPSLat=49.77971, GPSLong=19.08136},
                new BusStop {Name = "Żywiecka Mikuszowice Krakowskie", BusID = 2, GPSLat=49.77971, GPSLong=19.08136},
                new BusStop {Name = "Mikuszowice Dom Ludowy", BusID = 2, GPSLat=49.78537, GPSLong=19.07338},
                new BusStop {Name = "Żywiecka Dworek", BusID = 2, GPSLat=49.79321, GPSLong=19.06662},
                new BusStop {Name = "Żywiecka Pawia", BusID = 2, GPSLat=49.79695, GPSLong=19.06315 },
                new BusStop {Name = "Żywiecka Leszczyny", BusID = 2, GPSLat=49.80221, GPSLong=19.0584 },
                new BusStop {Name = "Żywiecka Hotel", BusID = 2, GPSLat=49.806, GPSLong=19.05656 },
                new BusStop {Name = "Żywiecka Osiedle Grunwaldzkie", BusID = 2, GPSLat=49.81208, GPSLong=19.05615 },
                new BusStop {Name = "Dmowskiego Urząd Miejski", BusID = 2, GPSLat=49.821, GPSLong=19.0528},
                new BusStop {Name = "Hotel Prezydent", BusID = 2, GPSLat=49.8278, GPSLong=19.04501  },
                new BusStop {Name = "3 Maja Dworzec", BusID = 2, GPSLat=49.8278, GPSLong=19.04501  },
                new BusStop {Name = "Piastowska Lubertowicza", BusID = 2, GPSLat=49.8268, GPSLong=19.03617 },
                new BusStop {Name = "Piastowska Wita Stwosza", BusID = 2, GPSLat=49.82472, GPSLong=19.02999 },
                new BusStop {Name = "Piastowska Sobieskiego", BusID = 2, GPSLat=49.82115, GPSLong=19.02429},
                new BusStop {Name = "Cieszyńska Hulanka", BusID = 2, GPSLat=49.81387, GPSLong=19.01802 },
            };
            busStops.ForEach(b => context.BusStops.Add(b));
            //context.SaveChanges();
            base.Seed(context);

        }
    }
}