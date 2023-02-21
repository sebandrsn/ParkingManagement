namespace ParkingManagement.Domain.Entities
{
    public class ParkingFee
    {
        public Guid ParkingFeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public decimal HourlyRate { get; set; }
        public Vehicle Vehicle { get; set; } = new Vehicle();
    }
}
