namespace SmartRides.Models.Entities
{
    public class AvailableSeat
    {
        public int AvailableSeatId { get; set; }
        public int BusId { get; set; }
        public int SeatId { get; set; }
        public int RideScheduleId { get; set; }
        public bool IsAvailable { get; set; }

        public Bus Bus { get; set; }
        public Seat Seat { get; set; }
        public RideSchedule RideSchedule { get; set; }
    }
}
