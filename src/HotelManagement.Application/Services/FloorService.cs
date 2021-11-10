using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class FloorService : IFloorService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;

        public FloorService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }

        public async Task<IList<int>> Get()
        {
            var query = await _worker.Floors.GetAll();
            return query.Select(x => x.Number).ToList();
        }

        public async Task<IList<FloorDTO>> GetAll()
        {
            var query = await _worker.Floors.LoadRoomInFloor();
            return _mapper.Map<IList<Floor>, IList<FloorDTO>>(query);
        }

        public async Task<string> Add(int number)
        {
            var query = await _worker.Floors.Get(x => x.Number == number);
            if (query is not null)
                return "Đã tồn tại";
            await _worker.Floors.Add(new Floor {Number = number});
            await _worker.Commit();
            return "Thêm thành công";
        }

        public async Task<string> Update(int id, int number)
        {
            var query = await _worker.Floors.Get(x => x.Id == id);
            if (query is null)
                return "Không tồn tại";
            query.Number = number;
            await _worker.Floors.Update(query);
            await _worker.Commit();
            return "Cập nhật thành công";
        }
    }
}