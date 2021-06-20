using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Location
    {
        public Location()
        {
            RideStops = new List<RideStop>();
            StartPoints = new List<Ride>();
            DestinationPoints = new List<Ride>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string StationName { get; set; }

        public ICollection<Ride> StartPoints { get; set; }
        public ICollection<Ride> DestinationPoints { get; set; }
        public ICollection<RideStop> RideStops { get; set; }
    }
}
