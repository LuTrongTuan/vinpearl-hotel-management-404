using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Account;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ISendMail
    {
        public void sendMail(AccountDTO acc);
    }
}