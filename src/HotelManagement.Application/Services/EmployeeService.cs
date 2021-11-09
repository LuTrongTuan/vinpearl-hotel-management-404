using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs.Employee;
using HotelManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;

namespace HotelManagement.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _worker;
        private EmployeeDTO _employeeDto;
        public EmployeeService(IUnitOfWork worker)
        {
            _worker = worker;
        }
        public Task<string> AddEmployee(Employee obj)
        {
            throw new System.NotImplementedException();
        }

        //public async Task<IList<EmployeeDTO>> GetList()
        //{
            
        //    return 
        //}

        public Task<IList<EmployeeDTO>> GetList(string name)
        {
            throw new System.NotImplementedException();
        }
        public Task<string> UpdateEmployee(Employee obj)
        {
            throw new System.NotImplementedException();
        }
    }
}