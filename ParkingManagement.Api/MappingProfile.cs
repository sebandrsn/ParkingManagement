using AutoMapper;
using ParkingManagement.Api.Models;
using ParkingManagement.Domain.Entities;

namespace ParkingManagement.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ParkingFee, ParkingFeeModel>();
            CreateMap<Vehicle, VehicleModel>();
        }
    }
}
