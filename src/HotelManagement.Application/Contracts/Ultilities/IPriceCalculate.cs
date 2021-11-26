using System;
using System.Collections.Generic;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Receipt;

namespace HotelManagement.Application.Contracts.Ultilities
{
    public interface IPriceCalculate
    {
        public double ByDay(DateTime start, DateTime end, double price);
        public double ByHour(DateTime start, DateTime end, double price);
        public double ServiceCalculate(IEnumerable<ServiceReceiptDTO> souce);
    }
}