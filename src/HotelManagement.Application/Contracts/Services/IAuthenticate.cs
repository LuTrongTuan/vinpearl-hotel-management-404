using System.Threading.Tasks;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IAuthenticate
    {
        Task<bool> authenticate(AccountDTO account);
    }
}