using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;
        private readonly IGenerator _generator;
        private Room _room;

        public RoomService(IUnitOfWork worker, IMapper mapper,
            IGenerator generator)
        {
            _worker = worker;
            _mapper = mapper;
            _generator = generator;
        }

        public async Task<string> AddRoom(IEnumerable<CreateRoomDTO> room)
        {
            foreach (var time in room)
            {
                var lastRoomName = await _worker.Rooms.GetLassRoomName("P" + time.Floor);
                var max = Convert.ToInt32(lastRoomName[2..]);
                for (int i = 0; i < time.Quantity; i++)
                {
                    max += 1;
                    _room = new()
                    {
                        Name = _generator.Name(time.Floor, max),
                        Status = 0,
                        TypeId = time.RoomType
                    };
                    await _worker.Rooms.Add(_room);
                }
            }
            await _worker.Commit();
            return "Thêm thành công";
        }

        public async Task<IList<RoomListDTO>> Get(string _name)
        {
            var query = await _worker.Rooms.GetAll();
            var search = query.Where(c => c.Name.ToLower().StartsWith(_name.ToLower())).ToList();
            return _mapper.Map<IList<Room>, IList<RoomListDTO>>(search);
        }

        public async Task<RoomDetailDTO> GetDetail(int id)
        {
            var result = await _worker.Rooms.Get(x => x.Id == id);
            return _mapper.Map<RoomDetailDTO>(result);
        }

        public async Task<string> Update(RoomDetailDTO room)
        {
            _room = await _worker.Rooms.Get(x => x.Id == room.Id);
            if (_room == null)
            {
                return "Không tồn tại";
            }
            _room.Name = room.Name;
            _room.Status = room.Status;
            await _worker.Rooms.Update(_room);
            await _worker.Commit();
            return "Sửa thành công";
        }
    }
}