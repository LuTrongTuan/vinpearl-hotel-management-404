using System;

namespace HotelManagement.Application.DTOs
{
    public class HistoryDTO
    {
        public int Status { get; set; }
        public double Payment { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}