namespace HotelManagement.Domain
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public virtual Account Accound { get; set; }
    }
}