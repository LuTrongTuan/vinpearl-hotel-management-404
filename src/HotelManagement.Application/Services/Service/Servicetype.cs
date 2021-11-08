using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Service;
using HotelManagement.Domain;


namespace HotelManagement.Application.Services
{
    public class Servicetype:IServiceType
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;
        private ServiceType _ser;
        public Servicetype(IUnitOfWork work, IMapper mapper)
        {
            _work = work;
            _mapper = mapper;
        }
        public async Task Add(ServicetypeDTO sertype)
        {
            _ser = new ServiceType {Name = sertype.Name};
            await _work.ServiceTypes.Add(_ser);
            await _work.Commit();
        }

        public async Task Update(ServicetypeDTO sertype)
        {
            _ser = await _work.ServiceTypes.Get(x => x.Id == sertype.Id);
            if (_ser is null) return;
            _ser.Name = sertype.Name;
            await _work.ServiceTypes.Update(_ser);
            await _work.Commit();
        }

        public async Task<IEnumerable<ServicetypeDTO>> Get()
        {
            var result = await _work.ServiceTypes.GetAll();
            return _mapper.Map<IList<ServiceType>, IList<ServicetypeDTO>>(result);
        }

        public async Task<IList<ServicetypeDTO>> getype(string name)
        {
            var result = await _work.ServiceTypes.GetAll();
            var total = result.Where(c => c.Name == name).ToList();
            return _mapper.Map<IList<ServiceType>, IList<ServicetypeDTO>>(total);
        }
    }
}