using System.Threading.Tasks;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IAuthenticate
    {
        Task<bool> authenticate(AccountDTO account);
    }
}