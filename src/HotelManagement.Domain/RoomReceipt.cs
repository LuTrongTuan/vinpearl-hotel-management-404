namespace HotelManagement.Domain
{
    public class RoomReceipt
    {
        public int RoomId { get; set; }
        public int ReceiptId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}