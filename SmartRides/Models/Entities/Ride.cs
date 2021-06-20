using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Ride
    {
        public Ride()
        {
            RideStops = new List<RideStop>();
            RideDates = new List<RideDate>();
        }

        public int RideId { get; set; }
        public int StartPointId { get; set; }
        public int DestinationPointId { get; set; }
        public double TotalHours { get; set; }

        public Location StartPoint { get; set; }
        public Location DestinationPoint { get; set; }

        public ICollection<RideStop> RideStops { get; private set; }
        public ICollection<RideDate> RideDates { get; private set; }
    }
}
