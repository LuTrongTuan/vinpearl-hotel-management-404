using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IRoomTypeService
    {
        Task Add(RoomTypeDTO roomtype);
        Task Update(RoomTypeDTO roomType);
        Task<IList<RoomTypeDTO>> Get();
        Task<RoomTypeDTO> GetType(int id);
    }
}