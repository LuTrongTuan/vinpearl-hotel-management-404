namespace HotelManagement.Application.DTOs.Room
{
    public class RoomDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int typeId { get; set; }
        public int FloorNumber { get; set; }
        public RoomTypeDTO RoomType { get; set; }
    }
}