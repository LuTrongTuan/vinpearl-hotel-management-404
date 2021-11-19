using System;

namespace HotelManagement.Application.DTOs.Employee
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameRole { get; set; }
    }
}