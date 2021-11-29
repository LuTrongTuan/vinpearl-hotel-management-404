using System;

namespace HotelManagement.Domain
{
    public class History : Entity, ITime
    {
        public int Status { get; set; }
        public double Payment { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        
        public int DetailId { get; set; }
        public virtual ReceiptDetail Detail { get; set; }
    }
}