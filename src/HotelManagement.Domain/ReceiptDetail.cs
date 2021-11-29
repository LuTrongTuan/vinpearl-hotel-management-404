using System;
using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class ReceiptDetail : Entity, ITime
    {
        public DateTime CreateAt { get; set; }
        public DateTime Checkout { get; set; }
        public int ReceiptId { get; set; }
        public int RoomId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<ServiceReceipt> Services { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<CustomerReceipt> Customers { get; set; }
    }
}