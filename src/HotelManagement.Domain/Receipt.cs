namespace HotelManagement.Domain
{
    public class Receipt : Entity
    {
        public double Deposit { get; set; }
        public double Payment { get; set; }
        public int Number { get; set; }
        public string Note { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int IdentificationId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ReceiptDetail Detail { get; set; }
        public virtual Identification Identification { get; set; }
    }
}