using System;

namespace SmartRides.Models.Entities
{
    public class Customer : User
    {
        public string PersonalIdentifier { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public double Discount { get; set; }

        public CustomerType CustomerType { get; set; }
    }
}
