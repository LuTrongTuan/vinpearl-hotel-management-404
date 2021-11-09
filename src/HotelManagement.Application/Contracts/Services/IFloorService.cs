using System.Threading.Tasks;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IFloorService
    {
        Task<string> Add(int number);
        Task<string> Update(int id, int number);
    }
}