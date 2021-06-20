using System.Collections.Generic;

namespace SmartRides.Models.Entities
{
    public class RideSchedule
    {
        public RideSchedule()
        {
            AvailableSeats = new List<AvailableSeat>();
        }

        public int RideScheduleId { get; set; }
        public int RideDateId { get; set; }
        public int ScheduleId { get; set; }

        public RideDate RideDate { get; set; }
        public Schedule Schedule { get; set; }

        public ICollection<AvailableSeat> AvailableSeats { get; private set; }
    }
}
