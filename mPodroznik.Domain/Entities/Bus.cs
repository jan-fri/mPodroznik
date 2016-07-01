using Newtonsoft.Json;
using System.Collections.Generic;

namespace mPodroznik.Domain.Entities
{
    public class Bus
    {

        public int ID { get; set; }
        public string BusNumber { get; set; }
        public virtual ICollection<BusStop> BusStops { get; set; }

    }
}
