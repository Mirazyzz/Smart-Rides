using System;

namespace SmartRides.Models.Entities
{
    public class Driver
    {
        public int DriverId { get; set; }
        public int BusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public Bus Bus { get; set; }
    }
}
