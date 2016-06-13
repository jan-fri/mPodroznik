using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using mPodroznik.Models;

namespace mPodroznik.DAL
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
                new BusStop {Name = "Cygański Las", BusID = 1},
                new BusStop {Name = "Bystrzańska Olszówka", BusID = 1},
                new BusStop {Name = "Długa Zajezdnia MZK", BusID = 1},
                new BusStop {Name = "Armii Krajowej Szpital", BusID = 1},
                new BusStop {Name = "Partyzantów Folwark", BusID = 1 },
                new BusStop {Name = "Partyzantów Apena", BusID = 1 },
                new BusStop {Name = "Plac Mickiewicza", BusID = 1 },
                new BusStop {Name = "Plac Żwirki i Wigury", BusID = 1},
                new BusStop {Name = "Hotel Prezydent", BusID = 1},
                new BusStop {Name = "3 Maja Dworzec", BusID = 1 },
                new BusStop {Name = "Piastowska Lubertowicza", BusID = 1 },
                new BusStop {Name = "Piastowska Wita Stwosza", BusID = 1},
                new BusStop {Name = "Piastowska Sobieskiego", BusID = 1 },
                new BusStop {Name = "Cieszyńska Hulanka", BusID = 1},
                new BusStop {Name = "Szarotki Cieszyńska", BusID = 1 },
                new BusStop {Name = "Szarotki SAM", BusID = 1},

                new BusStop {Name = "Mikuszowice Stalownik", BusID = 2},
                new BusStop {Name = "Żywiecka Mikuszowice Krakowskie", BusID = 2},
                new BusStop {Name = "Mikuszowice Dom Ludowy", BusID = 2},
                new BusStop {Name = "Żywiecka Dworek", BusID = 2},
                new BusStop {Name = "Żywiecka Pawia", BusID = 2 },
                new BusStop {Name = "Żywiecka Leszczyny", BusID = 2 },
                new BusStop {Name = "Żywiecka Hotel", BusID = 2 },
                new BusStop {Name = "Żywiecka Osiedle Grunwaldzkie", BusID = 2 },
                new BusStop {Name = "Dmowskiego Urząd Miejski", BusID = 2},
                new BusStop {Name = "Hotel Prezydent", BusID = 2 },
                new BusStop {Name = "3 Maja Dworzec", BusID = 2 },
                new BusStop {Name = "Piastowska Lubertowicza", BusID = 2},
                new BusStop {Name = "Piastowska Wita Stwosza", BusID = 2 },
                new BusStop {Name = "Piastowska Sobieskiego", BusID = 2},
                new BusStop {Name = "Cieszyńska Hulanka", BusID = 2 },
            };
            busStops.ForEach(b => context.BusStops.Add(b));

            //context.SaveChanges();
            base.Seed(context);

        }
    }
}