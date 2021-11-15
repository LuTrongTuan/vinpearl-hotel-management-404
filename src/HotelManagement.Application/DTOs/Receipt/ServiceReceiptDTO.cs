namespace HotelManagement.Application.DTOs.Receipt
{
    public class ServiceReceiptDTO
    {
        public int Quantity { get; set; }
        public int ServiceId { get; set; }
        public int ReceiptId { get; set; }
        public double Total { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
    }
}