using System.Collections.Generic;

namespace HotelManagement.Application.DTOs.Room
{
    public class FloorDTO
    {
        public string Floor { get; set; }
        public int Id { get; set; }
        public IEnumerable<RoomListDTO> Rooms { get; set; }
    }
}