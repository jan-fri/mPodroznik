using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPodroznik.Models
{
    public class Bus
    {
        public int ID { get; set; }
        public string BusNumber { get; set; }

        public virtual ICollection<BusStop> BusStops { get; set; }

    }
}
