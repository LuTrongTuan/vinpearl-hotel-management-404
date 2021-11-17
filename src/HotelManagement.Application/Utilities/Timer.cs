using System;
using HotelManagement.Application.Contracts.Ultilities;

namespace HotelManagement.Application.Utilities
{
    public class Timer : ITimer
    {
        public int GetDays(DateTime start, DateTime end)
        {
            var time = end.Day - start.Day;
            return time == 0 ? 1 : time;
        }

        public int GetHours(DateTime start, DateTime end, int minute = 0)
        {
            var times = end.Subtract(start).TotalMinutes;
            var hours = Convert.ToInt32(times / 60);
            var minutes = times - (hours * 60);
            return minutes > minute ? hours + 1 : hours;
        }
    }
}