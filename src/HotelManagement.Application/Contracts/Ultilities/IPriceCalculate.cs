using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Contracts.Ultilities
{
    public interface IPriceCalculate
    {
        double ByDay(TransactionDTO transaction, double price);
        double ByHour(TransactionDTO transaction, double price);
    }
}