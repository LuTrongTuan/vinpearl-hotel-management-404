namespace HotelManagement.Application.DTOs.Room
{
    public class RoomTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ByDay { get; set; }
        public double ByHour { get; set; }
        public double ByNight { get; set; }

    }
}