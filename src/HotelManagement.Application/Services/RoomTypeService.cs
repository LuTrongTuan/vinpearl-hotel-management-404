using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;
        private RoomType _roomType;

        public RoomTypeService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task Add(RoomTypeDTO roomtype)
        {
            _roomType = new RoomType
            {
                Name = roomtype.Name,
                ByDay = roomtype.ByDay,
                ByHour = roomtype.ByHour
            };
            await _worker.RoomTypes.Add(_roomType);
            await _worker.Commit();
        }
        public async Task Update(RoomTypeDTO roomType)
        {
            _roomType = await _worker.RoomTypes.Get(x => x.Id == roomType.Id);
            if(_roomType is null) return;
            _roomType.Name = roomType.Name;
            _roomType.ByDay = roomType.ByDay;
            _roomType.ByHour = roomType.ByHour;
            await _worker.RoomTypes.Update(_roomType);
            await _worker.Commit();
        }
        public async Task<IList<RoomTypeDTO>> Get()
        {
            var result = await _worker.RoomTypes.GetAll();
            return _mapper.Map<IList<RoomType>, IList<RoomTypeDTO>>(result);
        }

        public async Task<RoomTypeDTO> GetType(int id)
        {
            var query = await _worker.RoomTypes.Get(x => x.Id == id);
            return _mapper.Map<RoomTypeDTO>(query);
            //return query.Name;
        }
    }
}