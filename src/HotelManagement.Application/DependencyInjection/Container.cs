using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HotelManagement.Application.Profiles;

namespace HotelManagement.Application.DependencyInjection
{
    public class Container : IContainer
    {
        private readonly IDictionary<Type, Type> _serviceCollection = new Dictionary<Type, Type>();

        public void Register<TInterface, TImplementation>()
            where TImplementation : TInterface
        {
            _serviceCollection[typeof(TInterface)] = typeof(TImplementation);
        }

        public void Register<TObject>()
            where TObject : class
        {
            _serviceCollection[typeof(TObject)] = typeof(TObject);
        }

        public TObject GetInstance<TObject>() => (TObject) CreateInstance(typeof(TObject));

        private object CreateInstance(Type type)
        {
            Type concreateType;
            try
            {
                concreateType = _serviceCollection[type];
                if (type == typeof(IMapper))
                    return MapperProvider.GetInstance();
            }
            catch
            {
                throw new Exception(type.Name + " is not registered");
            }
            var defaultConstructor = concreateType.GetConstructors()[0];
            var defaultParams = defaultConstructor.GetParameters();
            var parameter = defaultParams.Select(param => CreateInstance(param.ParameterType)).ToArray();
            return defaultConstructor.Invoke(parameter);
        }
    }
}