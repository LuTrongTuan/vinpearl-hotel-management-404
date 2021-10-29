using System.Collections.Generic;

namespace HotelManagement.Domain
{
    public class Identification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}