using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IRoomService
    {
        Task<string> AddRoom(IEnumerable<CreateRoomDTO> room);
        Task<IList<RoomListDTO>> Get();
        Task<RoomDetailDTO> GetDetail(int id);
    }
}