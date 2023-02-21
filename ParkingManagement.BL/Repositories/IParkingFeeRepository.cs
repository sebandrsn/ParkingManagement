using ParkingManagement.Domain.Entities;

namespace ParkingManagement.BL.Repositories
{
    public interface IParkingFeeRepository
    {
        Task<ParkingFee> GetByIdAsync(Guid id);
        Task<List<ParkingFee>> GetByFromAndToDateAsync(DateTime fromDate, DateTime toDate);
    }
}
