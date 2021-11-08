using AutoMapper;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DependencyInjection;
using HotelManagement.Application.Services;
using HotelManagement.Application.Utilities;

namespace HotelManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IContainer ConfigureApplicationServices(this IContainer container)
        {
            container.Register<IEncrypt, Encrypt>();
            container.Register<IPasswordService, PasswordService>();
            container.Register<IRoomTypeService, RoomTypeService>();
            container.Register<IRoomService, RoomService>();
            container.Register<IGenerator, Generator>();
            container.Register<IMapper, Mapper>();
            container.Register<IService, Service>();
            container.Register<IServiceType, Servicetype>();
            return container;
        }
    }
}