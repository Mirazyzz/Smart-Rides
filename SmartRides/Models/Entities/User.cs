using System;
using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public abstract class User
    {
        public User()
        {
            Tickets = new List<Ticket>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid PromoCode { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
