using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IFloorRepository : IGenericRepository<Floor>
    {
        Task<IList<Floor>> LoadRoomInFloor();
    }
}