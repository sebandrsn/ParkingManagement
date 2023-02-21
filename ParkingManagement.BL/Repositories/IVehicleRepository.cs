using ParkingManagement.Domain.Entities;

namespace ParkingManagement.BL.Repositories
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetByIdAsync(Guid vehicleId);
    }
}
