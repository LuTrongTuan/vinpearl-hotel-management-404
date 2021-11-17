using System;
using System.Linq;
using HotelManagement.Application.Contracts.Ultilities;
using HotelManagement.Application.DTOs;

namespace HotelManagement.Application.Utilities
{
    public class PriceCaculator : IPriceCalculate
    {
        private readonly ITimer _timer;

        public PriceCaculator(ITimer timer) => _timer = timer;

        public double ByDay(TransactionDTO transaction, double price)
        {
            var time = _timer.GetDays(transaction.ReceiptDetail.CheckIn.Date, transaction.ReceiptDetail.CheckOut.Date);
            var total = transaction.ServiceReceipts.Sum(service => service.Total);
            return total += (time * price);
        }

        public double ByHour(TransactionDTO transaction, double price)
        {
            var time = _timer.GetHours(transaction.ReceiptDetail.CheckIn, transaction.ReceiptDetail.CheckOut,
                15);
            var total = transaction.ServiceReceipts.Sum(service => service.Total);
            return total += (time * price);
        }
    }
}