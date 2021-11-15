using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Receipt;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IServiceReceiptService
    {
        Task Add(ServiceReceiptDTO source);
        Task Update(IList<ServiceReceiptDTO> source);
    }
}