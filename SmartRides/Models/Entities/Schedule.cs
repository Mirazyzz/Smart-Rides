using System;
using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class Schedule
    {
        public Schedule()
        {
            RideSchedules = new List<RideSchedule>();
        }

        public int ScheduleId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public ICollection<RideSchedule> RideSchedules { get; set; }
    }
}
