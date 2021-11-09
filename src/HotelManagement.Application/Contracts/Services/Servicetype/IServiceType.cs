using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IServiceType
    {
        Task Add(ServicetypeDTO sertype);
        Task Update(ServicetypeDTO sertype);
        Task<IEnumerable<ServicetypeDTO>> Get();
        Task<IList<ServicetypeDTO>> getype(string name);
    }
}