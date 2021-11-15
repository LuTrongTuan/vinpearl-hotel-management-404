namespace HotelManagement.Application.DTOs.Receipt
{
    public class ReceiptDTO
    {
        public int Status { get; set; }
        public double Deposit { get; set; }
        public double Payment { get; set; }
        public int Number { get; set; }
        public string Note { get; set; }
        public int IdentificationId { get; set; }
    }
}