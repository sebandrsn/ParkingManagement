using ParkingManagement.Api.Enums;

namespace ParkingManagement.Api.Models
{
    public class VehicleModel
    {
        public Guid VehicleId { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public VehicleType VehicleType { get; set; }
    }
}
