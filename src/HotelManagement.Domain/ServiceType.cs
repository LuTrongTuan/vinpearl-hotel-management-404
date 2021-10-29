using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class ServiceType : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}