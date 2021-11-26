using System;

namespace HotelManagement.Domain
{
    public class History : Entity, ITime
    {
        public int Status { get; set; }
        public double Payment { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime End { get; set; }
        
        public int Room { get; set; }
        public RoomReceipt Receipt { get; set; }
    }
}