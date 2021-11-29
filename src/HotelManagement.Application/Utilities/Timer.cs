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
            var startTime = Get(start);
            var endTime = Get(end);
            var totalMinutes = endTime.Subtract(startTime).TotalMinutes;
            var hour = Convert.ToInt32(Math.Floor(totalMinutes / 60));
            var remain = totalMinutes % 60;
            return remain > minute ? hour + 1 : hour;
        }

        private DateTime Get(DateTime value)
        {
            return new DateTime(1999, 1, 1, value.Hour, value.Minute, 0);
        }
    }
}