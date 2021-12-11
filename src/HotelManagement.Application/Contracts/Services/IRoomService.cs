using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IRoomService
    {
        Task<string> AddRoom(IEnumerable<CreateRoomDTO> room);
        Task<string> Update(RoomDetailDTO room);
        Task<IList<RoomListDTO>> Get(string name = "");
        Task<IList<RoomDetailDTO>> GetList();
        Task<RoomDetailDTO> GetDetail(int id);
        Task<IList<ReceiptDetail>> getTak(Expression<Func<ReceiptDetail, bool>> predicate);
    }
}