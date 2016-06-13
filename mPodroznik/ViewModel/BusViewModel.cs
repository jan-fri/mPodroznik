using System.Collections.Generic;

namespace mPodroznik.ViewModel
{
    public class BusViewModel
    {

        public int ID { get; set; }
        public string BusNumber { get; set; }
        public List<BusStopViewModel> BusStops { get; set; }

   }
}