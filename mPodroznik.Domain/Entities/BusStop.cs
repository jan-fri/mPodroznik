using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPodroznik.Domain.Entities
{
    public class BusStop
    {
        public int BusStopID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string GPSData { get; set; }
        public List<Bus> Buses { get; set; }
    }
}
