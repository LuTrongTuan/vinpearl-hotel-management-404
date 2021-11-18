using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IFloorService
    {
        Task<IList<FloorDTO>> Get();
        Task<IList<FloorDTO>> GetAll();
        Task<string> Add(int number);
        Task<string> Update(int id, int number);
    }
}