using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Service : Entity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

        public int ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<ServiceReceipt> ServiceReceipts { get; set; }
    }
}