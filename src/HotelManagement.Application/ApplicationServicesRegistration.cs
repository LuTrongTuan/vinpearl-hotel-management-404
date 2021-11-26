using AutoMapper;
using HotelManagement.Application.Contracts;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DependencyInjection;
using HotelManagement.Application.Services;
using HotelManagement.Application.Utilities;
using Service = HotelManagement.Application.Services.Service;

namespace HotelManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IContainer ConfigureApplicationServices(this IContainer container)
        {
            container.Register<IAuthenticate, Authenticate>();
            container.Register<IEncrypt, Encrypt>();
            container.Register<IPasswordService, PasswordService>();
            container.Register<IRoomTypeService, RoomTypeService>();
            container.Register<IRoomService, RoomService>();
            container.Register<IGenerator, Generator>();
            container.Register<IMapper, Mapper>();
            container.Register<IService, Service>();
            container.Register<IServiceType, Servicetype>();
            container.Register<IFloorService, FloorService>();
            container.Register<IIdentificationService, IdentificationService>();
            container.Register<IEmployeeService,EmployeeService>();
            container.Register<IRoleService, RoleService>();
            container.Register<ISendMail, SendMail>();
            container.Register<ITransacsion, Transacsion>();
            container.Register<ICustomerService, CustomerService>();
            container.Register<IServiceReceiptService, ServiceReceiptService>();
            container.Register<IPriceCalculate, PriceCaculator>();
            container.Register<ITimer, Timer>();
            //container.Register<IManyToManyHandle<CustomerReceipt, CustomerDTO>, ManyToManyHandler<CustomerReceipt, CustomerDTO>>();
            return container;
        }
    }
}