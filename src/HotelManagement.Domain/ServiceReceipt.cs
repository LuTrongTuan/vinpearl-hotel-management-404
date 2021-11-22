namespace HotelManagement.Domain
{
    public class ServiceReceipt
    {
        public int DetailId { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public virtual Service Service { get; set; }
        public virtual ReceiptDetail Detail { get; set; }
    }
}