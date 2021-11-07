using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Services
{
    public interface IEmployeeService
    {
        //Task<IList<EmployeeDTO>> GetList();
        Task<IList<EmployeeDTO>> GetList(string name);
        Task<string> AddEmployee(Employee obj);
        Task<string> UpdateEmployee(Employee obj);
    }
}