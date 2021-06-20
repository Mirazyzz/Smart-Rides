using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRides.Models.Entities
{
    public class Employee : User
    {
        public DateTime HireDate { get; set; }
        public decimal Discount { get; set; }
    }
}
