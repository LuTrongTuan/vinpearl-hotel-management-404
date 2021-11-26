using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ICustomerService
    {
        Task<IList<CustomerDTO>> GetList();
        Task<int> Add(CustomerDTO customer);
        Task Update(CustomerDTO customer);
        Task<IEnumerable<CustomerDTO>> Get();
        Task<IList<CustomerDTO>> Find(string name);
    }
}