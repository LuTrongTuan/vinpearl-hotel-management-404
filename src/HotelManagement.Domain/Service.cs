using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Service : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

        public int TypeId { get; set; }
        public virtual ServiceType Type { get; set; }
        public virtual ICollection<ServiceReceipt> Receipts { get; set; }
    }
}