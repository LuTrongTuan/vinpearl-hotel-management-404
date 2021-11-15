﻿using System;
using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class ReceiptDetail : Entity
    {
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }
        public int RoomId { get; set; }

        public int ReceiptId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<ServiceReceipt> ServiceReceipts { get; set; }
        //public virtual ICollection<RoomReceipt> RoomReceipts { get; set; }
    }
}