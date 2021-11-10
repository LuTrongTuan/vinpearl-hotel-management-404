using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IIdentificationService
    {
        Task<IList<IdentificationDTO>> Get();
    }
}