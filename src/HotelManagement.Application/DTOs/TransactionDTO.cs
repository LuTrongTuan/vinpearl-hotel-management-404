using System.Collections.Generic;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Application.DTOs.Room;

namespace HotelManagement.Application.DTOs
{
    public class TransactionDTO
    {
        public int RoomId { get; set; }
        public int EmployeeId { get; set; }
        public ReceiptDTO Receipt { get; set; }
        public ReceiptDetailDTO Detail { get; set; }
        public IList<ServiceReceiptDTO> Services { get; set; }
        public IList<HistoryDTO> Histories { get; set; }
        public IList<CustomerDTO> Customers { get; set; }
    }
}