using System.Collections.Generic;

namespace HotelManagement.Application.DTOs.Room
{
    public class FloorDTO
    {
        public int Floor { get; set; }
        public string Name { get; set; }
        public IEnumerable<RoomListDTO> Rooms { get; set; }
    }
}