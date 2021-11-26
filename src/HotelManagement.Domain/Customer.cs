using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public string IdentityNumber { get; set; }
        public int Type { get; set; }
        public virtual ICollection<CustomerReceipt> Receipts { get; set; }
        public virtual Identification Identification { get; set; }
    }
}