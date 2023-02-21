using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParkingManagement.Api.Models;
using ParkingManagement.BL.Repositories;

namespace ParkingManagement.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ParkingFeesController : ControllerBase
    {
        private readonly IParkingFeeRepository _parkingFeeRepository;
        private readonly IMapper _mapper;

        public ParkingFeesController(IParkingFeeRepository parkingFeeRepository, IMapper mapper)
        {
            _parkingFeeRepository = parkingFeeRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ParkingFeeModel>> Get(Guid id) 
        {
            var parkingFee = await _parkingFeeRepository.GetByIdAsync(id);

            if (parkingFee == null)
                return NotFound("Parking fee not found");

            return Ok(_mapper.Map<ParkingFeeModel>(parkingFee));
        }

        [HttpGet("{fromDate}/{toDate}")]
        public async Task<ActionResult<ParkingFeeModel>> Get(DateTime fromDate, DateTime toDate)
        {
            var parkingFee = await _parkingFeeRepository.GetByFromAndToDateAsync(fromDate, toDate);

            return Ok(_mapper.Map<List<ParkingFeeModel>>(parkingFee));
        }
    }
}
