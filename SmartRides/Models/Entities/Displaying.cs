using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRides.Models.Entities
{
    public class Displaying
    {
        public Displaying()
        {
            Tickets = new List<Ticket>();
        }

        public int DisplayingId { get; set; }
        public int RideScheduleId { get; set; }
        public bool IsDeparted { get; set; }
        public int AvailableSeatsCount { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
