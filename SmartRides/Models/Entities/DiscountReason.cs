using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class DiscountReason
    {
        public DiscountReason()
        {
            Tickets = new List<Ticket>();
        }

        public int DiscountReasonId { get; set; }
        public string DiscountName { get; set; }

        public ICollection<Ticket> Tickets { get; private set; }
    }
}
