using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Bus
    {
        public Bus()
        {
            AvailableSeats = new List<AvailableSeat>();
        }

        public int BusId { get; set; }
        public int SeatCount { get; set; }
        public int FloorCount { get; set; }
        public bool HasAirCondition { get; set; }
        public bool HasCharger { get; set; }
        public bool HasBuffet { get; set; }

        public Driver Driver { get; set; }

        public ICollection<AvailableSeat> AvailableSeats { get; private set; }
    }
}
