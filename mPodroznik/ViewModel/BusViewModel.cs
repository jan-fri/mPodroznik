using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mPodroznik.ViewModel
{
    public class BusViewModel
    {

        public int ID { get; set; }
        public string BusNumber { get; set; }
        public List<BusStopViewModel> BusStops { get; set; }

   }
}