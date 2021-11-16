using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IRoleService
    {
        Task<IList<RoleDTO>> GetRoles();
    }
}