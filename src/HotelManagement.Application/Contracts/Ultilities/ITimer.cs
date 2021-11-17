using System;

namespace HotelManagement.Application.Contracts.Ultilities
{
    public interface ITimer
    {
        int GetDays(DateTime start, DateTime end);
        int GetHours(DateTime start, DateTime end, int minute = 0);
    }
}