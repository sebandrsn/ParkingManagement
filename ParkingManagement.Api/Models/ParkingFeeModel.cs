
namespace ParkingManagement.Api.Models
{
    public class ParkingFeeModel
    {
        public Guid ParkingFeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public decimal HourlyRate { get; set; }
        public VehicleModel Vehicle { get; set; } = new VehicleModel();
    }
}
