using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IService
    {
        Task<string> AddService(ServiceDTO ser);
        Task<string> UpdateService(ServiceDTO ser);
        Task<IList<ServiceDTO>> Get();
        Task<IList<ServiceDTO>> Find(string name);
        Task<ServiceDTO> GetDetail(int id);
    }
}