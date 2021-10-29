using System;
using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}