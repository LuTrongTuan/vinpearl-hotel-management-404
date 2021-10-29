using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.DependencyInjection;
using HotelManagement.Infrastructure.Repositories;

namespace HotelManagement.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IContainer ConfigureInfrastructureServices(this IContainer container)
        {
            container.Register<IUnitOfWork, UnitOfWork>();
            return container;
        }
    }
}