using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}