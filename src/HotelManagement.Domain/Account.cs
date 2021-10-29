namespace HotelManagement.Domain
{
    public class Account : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}