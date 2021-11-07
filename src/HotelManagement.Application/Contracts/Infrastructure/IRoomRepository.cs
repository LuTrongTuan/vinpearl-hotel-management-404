using System.Threading.Tasks;
using HotelManagement.Domain;
namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        Task<string> GetLassRoomName(string floor);
    }
}