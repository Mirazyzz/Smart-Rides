using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class TicketClassAttribute
    {
        public TicketClassAttribute()
        {
            Tickets = new List<Ticket>();
        }

        public int TicketClassAttributeId { get; set; }
        public decimal StandardPrice { get; set; }
        public double DiscountRate { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
