using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class RoomType : Entity
    {
        public string Name { get; set; }
        public double ByDay { get; set; }
        public double ByHour { get; set; }
        public double ByNight { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}