using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Floor : Entity
    {
        public int Number { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}