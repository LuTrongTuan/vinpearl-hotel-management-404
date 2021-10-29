using System.Reflection;
using AutoMapper;

namespace HotelManagement.Application.Profiles
{
    public sealed class MapperProvider
    {
        private static IMapper _mapper;
        private static IConfigurationProvider _configuration;

        public MapperProvider()
        {
        }

        public static IMapper GetInstance()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(Assembly.GetExecutingAssembly());
            });

            return _mapper ??= new Mapper(_configuration);
        }
    }
}