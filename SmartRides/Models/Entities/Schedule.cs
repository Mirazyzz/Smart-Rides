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
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }

        public ICollection<RideSchedule> RideSchedules { get; set; }
    }
}
