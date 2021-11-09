using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IRoomService
    {
        Task<string> AddRoom(IEnumerable<CreateRoomDTO> room);
        Task<string> Update(RoomDetailDTO room);
        Task<IList<RoomListDTO>> Get();
        Task<IList<RoomListDTO>> GetSearch(string _name);
        Task<RoomDetailDTO> GetDetail(int id);
    }
}