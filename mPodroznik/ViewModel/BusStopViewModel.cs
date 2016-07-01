using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace mPodroznik.ViewModel
{
    public class BusStopViewModel
    {
        [Required]
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "busId")]
        public int BusID { get; set; }
        [JsonProperty(PropertyName = "busStopOrder")]
        public int BusStopOrder { get; set; }
        [Required]
        [JsonProperty(PropertyName = "busStopName")]
        public string BusStopName { get; set; }
        public string Street { get; set; }
        [Required]
        [JsonProperty(PropertyName = "gpsLat")]
        public double GPSLat { get; set; }
        [Required]
        [JsonProperty(PropertyName = "gpsLng")]
        public double GPSLong { get; set; }
    }
}