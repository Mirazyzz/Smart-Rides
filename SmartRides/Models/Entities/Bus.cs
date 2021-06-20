namespace SmartRides.Models.Entities
{
    public class Bus
    {
        public int BusId { get; set; }
        public int SeatCount { get; set; }
        public int FloorCount { get; set; }
        public bool HasAirCondition { get; set; }
        public bool HasCharger { get; set; }
        public bool HasBuffet { get; set; }

        public Driver Driver { get; set; }

    }
}
