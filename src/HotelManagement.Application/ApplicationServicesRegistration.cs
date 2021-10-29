using HotelManagement.Application.DependencyInjection;

namespace HotelManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IContainer ConfigureApplicationServices(this IContainer container)
        {
            return container;
        }
    }
}