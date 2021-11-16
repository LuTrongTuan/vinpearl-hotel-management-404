namespace HotelManagement.Domain
{
    public class RoomReceipt
    {
        public int ReceiptDetailId { get; set; }
        public int RoomId { get; set; }
        public virtual ReceiptDetail ReceiptDetail { get; set; }
        public virtual Room Room { get; set; }
    }
}