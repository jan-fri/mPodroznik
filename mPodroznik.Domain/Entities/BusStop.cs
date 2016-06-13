namespace mPodroznik.Domain.Entities
{
    public class BusStop
    {
        public int BusStopID { get; set; }
        public int BusID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string GPSData { get; set; }
        public virtual Bus Bus { get; set; }
    }
}