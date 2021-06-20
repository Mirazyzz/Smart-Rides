namespace SmartRides.Models.Entities
{
    public class BusSeat
    {
        public int BusSeatId { get; set; }
        public int BusId { get; set; }
        public int SeatId { get; set; }
        public bool IsAvailable { get; set; }

        public Bus Bus { get; set; }
        public Seat Seat { get; set; }
    }
}
