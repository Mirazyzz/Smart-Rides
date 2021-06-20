using System;

namespace SmartRides.Models.Entities
{
    public class RideSchedule
    {
        public int RideScheduleId { get; set; }
        public int RideDateId { get; set; }
        public int ScheduleId { get; set; }

        public RideDate RideDate { get; set; }
        public Schedule Schedule { get; set; }
    }
}
