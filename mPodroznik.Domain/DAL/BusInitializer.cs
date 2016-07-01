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
                new BusStop {BusStopOrder = 1, BusStopName = "Cygański Las", BusID = 1, GPSLat=49.79078, GPSLong = 19.04916},
                new BusStop {BusStopOrder = 2, BusStopName = "Bystrzańska Olszówka", BusID = 1, GPSLat=49.79555, GPSLong=19.05182},
                new BusStop {BusStopOrder = 3, BusStopName = "Długa Zajezdnia MZK", BusID = 1, GPSLat=49.7926, GPSLong=19.0466},
                new BusStop {BusStopOrder = 4, BusStopName = "Armii Krajowej Szpital", BusID = 1, GPSLat=49.79424, GPSLong=19.038},
                new BusStop {BusStopOrder = 5, BusStopName = "Partyzantów Folwark", BusID = 1, GPSLat=49.80317, GPSLong=19.04563 },
                new BusStop {BusStopOrder = 6, BusStopName = "Partyzantów Apena", BusID = 1, GPSLat=49.80875, GPSLong=19.04265 },
                new BusStop {BusStopOrder = 7, BusStopName = "Plac Mickiewicza", BusID = 1, GPSLat=49.81498, GPSLong=19.0448 },
                new BusStop {BusStopOrder = 8, BusStopName = "Plac Żwirki i Wigury", BusID = 1, GPSLat=49.81844, GPSLong=19.04407},
                new BusStop {BusStopOrder = 9, BusStopName = "Hotel Prezydent", BusID = 1, GPSLat=49.8233, GPSLong=19.04511},
                new BusStop {BusStopOrder = 10, BusStopName = "3 Maja Dworzec", BusID = 1, GPSLat=49.8278, GPSLong=19.04501 },
                new BusStop {BusStopOrder = 11, BusStopName = "Piastowska Lubertowicza", BusID = 1, GPSLat=49.8268, GPSLong=19.03617 },
                new BusStop {BusStopOrder = 12, BusStopName = "Piastowska Wita Stwosza", BusID = 1, GPSLat=49.82472, GPSLong=19.02999},
                new BusStop {BusStopOrder = 13, BusStopName = "Piastowska Sobieskiego", BusID = 1, GPSLat=49.82115, GPSLong=19.02429 },
                new BusStop {BusStopOrder = 14, BusStopName = "Cieszyńska Hulanka", BusID = 1, GPSLat=49.81387, GPSLong=19.01802},
                new BusStop {BusStopOrder = 15, BusStopName = "Szarotki Cieszyńska", BusID = 1, GPSLat=49.81174, GPSLong=19.01227 },
                new BusStop {BusStopOrder = 16, BusStopName = "Szarotki SAM", BusID = 1, GPSLat=49.80894, GPSLong=19.01738},

                new BusStop {BusStopOrder = 1, BusStopName = "Mikuszowice Stalownik", BusID = 2, GPSLat=49.77971, GPSLong=19.08136},
                new BusStop {BusStopOrder = 2, BusStopName = "Żywiecka Mikuszowice Krakowskie", BusID = 2, GPSLat=49.77971, GPSLong=19.08136},
                new BusStop {BusStopOrder = 3, BusStopName = "Mikuszowice Dom Ludowy", BusID = 2, GPSLat=49.78537, GPSLong=19.07338},
                new BusStop {BusStopOrder = 4, BusStopName = "Żywiecka Dworek", BusID = 2, GPSLat=49.79321, GPSLong=19.06662},
                new BusStop {BusStopOrder = 5, BusStopName = "Żywiecka Pawia", BusID = 2, GPSLat=49.79695, GPSLong=19.06315 },
                new BusStop {BusStopOrder = 6, BusStopName = "Żywiecka Leszczyny", BusID = 2, GPSLat=49.80221, GPSLong=19.0584 },
                new BusStop {BusStopOrder = 7, BusStopName = "Żywiecka Hotel", BusID = 2, GPSLat=49.806, GPSLong=19.05656 },
                new BusStop {BusStopOrder = 8, BusStopName = "Żywiecka Osiedle Grunwaldzkie", BusID = 2, GPSLat=49.81208, GPSLong=19.05615 },
                new BusStop {BusStopOrder = 9, BusStopName = "Dmowskiego Urząd Miejski", BusID = 2, GPSLat=49.821, GPSLong=19.0528},
                new BusStop {BusStopOrder = 10, BusStopName = "Hotel Prezydent", BusID = 2, GPSLat=49.8278, GPSLong=19.04501  },
                new BusStop {BusStopOrder = 11, BusStopName = "3 Maja Dworzec", BusID = 2, GPSLat=49.8278, GPSLong=19.04501  },
                new BusStop {BusStopOrder = 12, BusStopName = "Piastowska Lubertowicza", BusID = 2, GPSLat=49.8268, GPSLong=19.03617 },
                new BusStop {BusStopOrder = 13, BusStopName = "Piastowska Wita Stwosza", BusID = 2, GPSLat=49.82472, GPSLong=19.02999 },
                new BusStop {BusStopOrder = 14, BusStopName = "Piastowska Sobieskiego", BusID = 2, GPSLat=49.82115, GPSLong=19.02429},
                new BusStop {BusStopOrder = 15, BusStopName = "Cieszyńska Hulanka", BusID = 2, GPSLat=49.81387, GPSLong=19.01802 },
            };
            busStops.ForEach(b => context.BusStops.Add(b));
            //context.SaveChanges();
            base.Seed(context);

        }
    }
}