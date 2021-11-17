using System.Collections.Generic;
using HotelManagement.Application.DTOs.Receipt;
using HotelManagement.Domain;

namespace HotelManagement.Application.DTOs
{
    public class TransactionDTO
    {
        public int RoomId { get; set; }
        public int EmployeeId { get; set; }
        public ReceiptDTO Receipt { get; set; }
        public IList<ServiceReceiptDTO> ServiceReceipts { get; set; }
        public CustomerDTO Customer { get; set; }
        public ReceiptDetailDTO ReceiptDetail { get; set; }
    }
}