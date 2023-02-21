using ParkingManagement.Domain.Entities;
using ParkingManagement.Domain.Enums;

namespace ParkingManagement.BL.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private List<Vehicle> _vehicleData;

        public VehicleRepository()
        {
            _vehicleData = SeedVehicleData();
        }

        public async Task<Vehicle> GetByIdAsync(Guid vehicleId)
        {
            var vehicle = _vehicleData.Where(v => v.VehicleId == vehicleId).First();

            return vehicle;
        }

        // Seed data
        private List<Vehicle> SeedVehicleData()
        {
            return new List<Vehicle>()
            {
                new Vehicle()
                {
                    VehicleId = Guid.Parse("0bd4795a-f165-4d66-851f-9440ee3d12a0"),
                    LicensePlate = "UBZ192",
                    Model = "Volvo EX90",
                    VehicleType = VehicleType.Car
                },
                new Vehicle()
                {
                    VehicleId = Guid.Parse("6583f997-c58c-48f6-82ec-5ca3dba8090d"),
                    LicensePlate = "JAV418",
                    Model = "Ktm 450 EXC",
                    VehicleType = VehicleType.Motorcycle
                },
                new Vehicle()
                {
                    VehicleId = Guid.Parse("9ed9bf1b-12ae-4972-aca9-e13436758ceb"),
                    LicensePlate = "KAX395",
                    Model = "Triumph Daytona 675R",
                    VehicleType = VehicleType.Motorcycle
                },
                new Vehicle()
                {
                    VehicleId = Guid.Parse("d2a4fca5-b120-4356-a9cf-78202ac4e291"),
                    LicensePlate = "UVF941",
                    Model = "Peugeot 208",
                    VehicleType = VehicleType.Car
                },
                new Vehicle()
                {
                    VehicleId = Guid.Parse("cf98c731-6a43-4d2f-8a3f-efedb7983fb7"),
                    LicensePlate = "CYM948",
                    Model = "BMW i4",
                    VehicleType = VehicleType.Car
                },
            };
        }
    }
}
