using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.Services
{
    public class Service:IService
    {
        private readonly IUnitOfWork _work;
        private readonly IMapper _mapper;
        private Domain.Service _ser;
        public Service(IUnitOfWork work, IMapper mapper)
        {
            _work = work;
            _mapper = mapper;
        }
        public async Task<string> AddService(ServiceDTO ser)
        {
            _ser = new Domain.Service();
            await _work.Services.Add(_ser);
            await _work.Commit();
            return "thêm thành công";
        }

        public async Task<string> UpdateService(ServiceDTO ser)
        {
            _ser = await _work.Services.Get(x => x.Id == ser.Id);
            if (_ser == null)
            {
                return "không tồn tại";
            }
            _ser.Name = ser.Name;
            _ser.Price = ser.Price;
            var nametype = _work.ServiceTypes.Get(x => x.Id == ser.ServiceTypeId);
            _ser.ServiceTypeId = nametype.Id;
            await _work.Services.Update(_ser);
            await _work.Commit();
            return "sửa thành công";
        }

        public async Task<IList<ServiceDTO>> Get()
        {
            var query = await _work.Services.GetAll();
            return _mapper.Map<IList<Domain.Service>, IList<ServiceDTO>>(query);
        }

        public async Task<IList<ServiceDTO>> Find(string name)
        {
            var query = await _work.Services.GetAll();
            var list = query.Where(c => c.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return _mapper.Map<IList<Domain.Service>, IList<ServiceDTO>>(list);
        }


        public async Task<ServiceDTO> GetDetail(int id)
        {
            var query = await _work.Services.Get(x=>x.Id == id);
            return _mapper.Map<ServiceDTO>(query);
        }
    }
}