using System;
using HotelManagement.Application.Contracts.Ultilities;

namespace HotelManagement.Application.Utilities
{
    public class Timer : ITimer
    {
        public int GetDays(DateTime start, DateTime end)
        {
            var timeline = new DateTime(2021, 1, 1);

            if (start.Day > end.Day && start.Month != end.Month)
            {
                var totalStartDay = Convert.ToInt32(start.Subtract(timeline).TotalDays);
                var totalEndDay = Convert.ToInt32(end.Subtract(timeline).TotalDays);
                return totalEndDay - totalStartDay + 1;
            }

            var time = end.Day - start.Day;
            return time == 0 ? 1 : time;
        }

        public int GetHours(DateTime start, DateTime end, int minute = 0)
        {
            var totalMinutes = end.Subtract(start).TotalMinutes;
            var hour = Convert.ToInt32(Math.Floor(totalMinutes / 60));
            if (hour == 0)
                return 1;
            var remain = totalMinutes % 60;
            return remain > minute ? hour + 1 : hour;
        }
    }
}