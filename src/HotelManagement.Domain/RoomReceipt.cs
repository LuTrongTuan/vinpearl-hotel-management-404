using System;
using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class RoomReceipt : Entity, ITime
    {
        public int DetailId { get; set; }
        public int RoomId { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual ICollection<History> Histories { get; set; }
        public virtual ReceiptDetail Detail { get; set; }
        public virtual Room Room { get; set; }
    }
}