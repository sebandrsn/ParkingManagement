using ParkingManagement.Domain.Enums;

namespace ParkingManagement.Domain.Entities
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public VehicleType VehicleType { get; set; }
    }
}
