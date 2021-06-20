using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Seat
    {
        public Seat()
        {
            BusSeats = new List<BusSeat>();
        }

        public int SeatId { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public bool IsAtWindow { get; set; }

        public ICollection<BusSeat> BusSeats { get; private set; }
    }
}
