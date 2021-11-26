namespace HotelManagement.Domain
{
    public class CustomerReceipt : Entity
    {
        public int CustomerId { get; set; }
        public int ReceiptId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ReceiptDetail Receipt { get; set; }
    }
}