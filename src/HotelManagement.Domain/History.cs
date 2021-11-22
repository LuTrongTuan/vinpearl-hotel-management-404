namespace HotelManagement.Domain
{
    public class History : Entity
    {
        public int Status { get; set; }
        public double Payment { get; set; }
        
        public int Room { get; set; }
        public RoomReceipt Receipt { get; set; }
    }
}