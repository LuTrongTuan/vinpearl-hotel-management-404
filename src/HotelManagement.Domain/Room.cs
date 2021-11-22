using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public int Status { get; set; }

        public int TypeId { get; set; }
        public int FloorNumber { get; set; }
        public virtual RoomType Type { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual ICollection<RoomReceipt> Receipts { get; set; }
    }
}