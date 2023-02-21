using ParkingManagement.Domain.Entities;

namespace ParkingManagement.BL.Repositories
{
    public class ParkingFeeRepository : IParkingFeeRepository
    {
        private List<ParkingFee> _parkingFeeData;
        private readonly IVehicleRepository _vehicleRepository;

        public ParkingFeeRepository(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            _parkingFeeData = SeedParkingFeeData();
        }

        public async Task<ParkingFee> GetByIdAsync(Guid id)
        {
            var parkingFee = _parkingFeeData
                .Where(pf => pf.ParkingFeeId == id)
                .FirstOrDefault();

            return parkingFee;
        }

        public async Task<List<ParkingFee>> GetByFromAndToDateAsync(DateTime fromDate, DateTime toDate)
        {
            var parkingFees = _parkingFeeData
                .Where(pf => pf.StartTime >= fromDate && pf.StopTime <= toDate)
                .ToList();

            return parkingFees;
        }

        // Seed data
        private List<ParkingFee> SeedParkingFeeData()
        {
            return new List<ParkingFee>()
            {
                new ParkingFee()
                {
                    ParkingFeeId = Guid.Parse("6ff55f05-1c7f-40d1-a550-13b59d680709"),
                    StartTime = new DateTime(2023, 01, 05, 10, 05, 23),
                    StopTime = new DateTime(2023, 01, 05, 13, 07, 43),
                    HourlyRate = 12,
                    Vehicle = _vehicleRepository.GetByIdAsync(Guid.Parse("0bd4795a-f165-4d66-851f-9440ee3d12a0")).Result
                },
                new ParkingFee()
                {
                    ParkingFeeId = Guid.Parse("eb7697f1-9566-4e83-bf3e-7d100235a922"),
                    StartTime = new DateTime(2023, 02, 05, 14, 17, 14),
                    StopTime = new DateTime(2023, 02, 05, 16, 59, 08),
                    HourlyRate = 12,
                    Vehicle = _vehicleRepository.GetByIdAsync(Guid.Parse("6583f997-c58c-48f6-82ec-5ca3dba8090d")).Result
                },
                new ParkingFee()
                {
                    ParkingFeeId = Guid.Parse("9b3538aa-e0d4-4275-8230-a3f36f255657"),
                    StartTime = new DateTime(2023, 01, 16, 08, 05, 52),
                    StopTime = new DateTime(2023, 01, 16, 17, 45, 32),
                    HourlyRate = 12,
                    Vehicle = _vehicleRepository.GetByIdAsync(Guid.Parse("9ed9bf1b-12ae-4972-aca9-e13436758ceb")).Result
                },
                new ParkingFee()
                {
                    ParkingFeeId = Guid.Parse("a83c4869-4495-4c87-a020-609f117da778"),
                    StartTime = new DateTime(2023, 01, 01, 06, 03, 26),
                    StopTime = new DateTime(2023, 01, 01, 12, 46, 28),
                    HourlyRate = 12,
                    Vehicle = _vehicleRepository.GetByIdAsync(Guid.Parse("d2a4fca5-b120-4356-a9cf-78202ac4e291")).Result
                },
                new ParkingFee()
                {
                    ParkingFeeId = Guid.Parse("21d487d3-c202-496e-9ea2-a4f134d95247"),
                    StartTime = new DateTime(2023, 02, 20, 21, 02, 21),
                    StopTime = new DateTime(2023, 02, 20, 23, 36, 37),
                    HourlyRate = 12,
                    Vehicle = _vehicleRepository.GetByIdAsync(Guid.Parse("cf98c731-6a43-4d2f-8a3f-efedb7983fb7")).Result
                },
            };
        }
    }
}
