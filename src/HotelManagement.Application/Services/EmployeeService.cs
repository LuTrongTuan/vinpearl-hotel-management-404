using HotelManagement.Application.Contracts.Services;
using HotelManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.DTOs;
using HotelManagement.Application.DTOs.Employee;


namespace HotelManagement.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _worker;
        private readonly IMapper _mapper;
        private Employee _employee;
        private Account _account;
        public EmployeeService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }
        public async Task<string> AddEmployee(EmployeeDTO obj, AccountDTO a)
        {
            var emp = _mapper.Map<Employee>(obj);
            var acc = _mapper.Map<Account>(a);
            await _worker.Employees.Add(emp);
            await _worker.Accounts.Add(acc);
            await _worker.Commit();
            return "thêm thành công";
        }

        public async Task<IList<roleDTO>> GetList()
        {
            var query = await _worker.Roles.GetAll();
            return _mapper.Map<IList<Role>, IList<roleDTO>>(query);
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