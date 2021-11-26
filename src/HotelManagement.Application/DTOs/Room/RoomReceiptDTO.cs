using System.Collections.Generic;

namespace HotelManagement.Application.DTOs.Room
{
    public class RoomReceiptDTO
    {
        public int RoomId { get; set; }
        public int Status { get; set; }
        public double Payment { get; set; }

        public IList<HistoryDTO> Histories { get; set; }
    }
}