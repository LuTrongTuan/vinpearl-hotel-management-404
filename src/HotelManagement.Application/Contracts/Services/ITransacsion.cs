using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Room;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ITransacsion
    {
        Task<string> Create(TransactionDTO source);
        Task<TransactionDTO> Query(int roomId);
        Task<RoomDetailDTO> GetRoomDetail(int id);
        Task<IList<ServiceDTO>> GetServices();
        Task<IList<IdentificationDTO>> GetIdentifications();
        Task<string> Update(TransactionDTO source);
        Task<string> Checkout(int id);
    }
}