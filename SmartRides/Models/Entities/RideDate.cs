using System;
using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class RideDate
    {
        public RideDate()
        {
            RideSchedules = new List<RideSchedule>();
        }

        public int RideDateId { get; set; }
        public int RideId { get; set; }
        public DateTime Date { get; set; }

        public Ride Ride { get; set; }

        public ICollection<RideSchedule> RideSchedules { get; set; }
    }
}
