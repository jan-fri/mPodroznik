﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mPodroznik.ViewModel
{
    public class BusStopViewModel
    {
        public int BusStopID { get; set; }
        public int BusID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string GPSData { get; set; }
    }
}