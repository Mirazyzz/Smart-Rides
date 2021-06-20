using System;

namespace SmartRides.Models.Entities
{
    public class RideSchedule
    {
        public int RideScheduleId { get; set; }
        public int RideDateId { get; set; }
        public TimeSpan Time { get; set; }

        public RideDate RideDate { get; set; }
    }
}
