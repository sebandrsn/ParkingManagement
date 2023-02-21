using Microsoft.Extensions.DependencyInjection;
using ParkingManagement.BL.Repositories;

namespace ParkingManagement.BL
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IParkingFeeRepository, ParkingFeeRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();

            return services;
        }
    }
}
