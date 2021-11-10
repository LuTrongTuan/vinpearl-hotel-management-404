using System;

namespace HotelManagement.Application.DTOs
{
    public class ReceiptDTO
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public CustomerDTO Customer { get; set; }
        public double Deposit { get; set; }
    }
}