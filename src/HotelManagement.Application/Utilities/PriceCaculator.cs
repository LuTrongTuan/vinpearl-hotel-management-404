using System;
using System.Collections.Generic;
using System.Linq;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Service;

namespace HotelManagement.Application.Utilities
{
    public class PriceCaculator : IPriceCalculate
    {
        private readonly ITimer _timer;

        public PriceCaculator(ITimer timer) => _timer = timer;

        public double ByDay(DateTime start, DateTime end, double price) => _timer.GetDays(start, end) * price;

        public double ByHour(DateTime start, DateTime end, double price) => _timer.GetHours(start, end,15) * price;

        public double ServiceCalculate(IEnumerable<ServiceReceiptDTO> souce) => souce.Sum(x => x.Total);
    }
}