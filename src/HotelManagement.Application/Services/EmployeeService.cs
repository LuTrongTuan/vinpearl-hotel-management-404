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
        private IEncrypt _encrypt;
        private Employee _employee;
        private Account _account;
        public EmployeeService(IUnitOfWork worker, IMapper mapper, IEncrypt encrypt)
        {
            _worker = worker;
            _mapper = mapper;
            _encrypt = encrypt;
        }

        public async Task<IEnumerable<RoleDTO>> GetList()
        {
            var result = await _worker.Roles.GetAll();
            return _mapper.Map<IList<Role>, IList<RoleDTO>>(result);
        }

        public Task<IList<EmployeeDTO>> GetList(string name)
        {
            throw new System.NotImplementedException();
        }

        public async Task<string> AddEmployee(Account obj)
        { 
            var emp = _mapper.Map<Account>(obj);
            emp.Password = _encrypt.Encrypt("welcome");
            await _worker.Accounts.Add(emp);
            await _worker.Commit();
            return "ok";
        }

        public Task<string> UpdateEmployee(Employee obj)
        {
            throw new System.NotImplementedException();
        }
    }
}