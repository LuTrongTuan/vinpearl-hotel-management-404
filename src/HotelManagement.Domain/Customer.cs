using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentityNumber { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}