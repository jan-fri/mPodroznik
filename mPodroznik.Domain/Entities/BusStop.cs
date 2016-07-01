using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace mPodroznik.Domain.Entities
{
    public class BusStop
    {
        public int ID { get; set; }
        public int BusID { get; set; }
        public int BusStopOrder { get; set; }
        [Required]
        public string BusStopName { get; set; }
        public string Street { get; set; }
        [Required]
        public double GPSLat { get; set; }
        [Required]
        public double GPSLong { get; set; }
        public virtual Bus Bus { get; set; }
    }
}