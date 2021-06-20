using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRides.Models.Entities
{
    public class TicketSeat
    {
        public int TicketSeatId { get; set; }
        public int TicketId { get; set; }
        public int SeatId { get; set; }

        public Ticket Ticket { get; set; }
        public Seat Seat { get; set; }
    }
}
