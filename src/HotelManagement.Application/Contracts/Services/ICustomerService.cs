using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ICustomerService
    {
        Task<CustomerDTO> GetDetail(int id);
        Task Add(CustomerDTO customer);
    }
}