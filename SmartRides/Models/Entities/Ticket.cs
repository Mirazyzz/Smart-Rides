using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            Seats = new List<TicketSeat>();
        }

        public int TicketId { get; set; }
        public string TicketNumber { get; set; }
        public decimal Price { get; set; }

        public int TicketClassAttributeId { get; set; }
        public int DiscountReasonId { get; set; }
        public int CustomerId { get; set; }
        public int DisplayingId { get; set; }

        public TicketClassAttribute TicketClassAttribute { get; set; }
        public DiscountReason DiscountReason { get; set; }
        public User Customer { get; set; }
        public Displaying Displaying { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public TicketType TicketType { get; set; }

        public ICollection<TicketSeat> Seats { get; set; }
    }
}
