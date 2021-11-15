using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<RoleDTO>> GetListrole();
        Task<IEnumerable<EmployeeDTO>> GetList();
        Task<IList<EmployeeDTO>> Find(string name);
        Task<string> AddEmployee(Account obj);
        Task<string> UpdateEmployee(Employee obj);
    }
}