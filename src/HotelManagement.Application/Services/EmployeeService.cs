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

        public async Task<IList<EmployeeDTO>> GetList()
        {
            //_employeeDto = (from x in _worker.Employees.GetAll()
            //    join y in _worker.Accounts.GetAll() on x.Id equals y.EmployeeId
            //    join z in _worker.Roles.GetAll() on y.EmployeeId equals z.Id
            //    select new EmployeeDTO()
            //    {

            //    });
            throw new System.NotImplementedException();
        }

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