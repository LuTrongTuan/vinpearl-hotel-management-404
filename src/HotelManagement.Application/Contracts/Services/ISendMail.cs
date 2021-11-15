using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Services
{
    public interface ISendMail
    {
        public void sendMail(AccountDTO acc);
    }
}