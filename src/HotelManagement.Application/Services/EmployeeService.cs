using HotelManagement.Application.Contracts.Services;
using HotelManagement.Domain;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<RoleDTO>> GetListrole()
        {
            var result = await _worker.Roles.GetAll();
            return _mapper.Map<IList<Role>, IList<RoleDTO>>(result);
        }
        public async Task<IEnumerable<EmployeeDTO>> GetList()
        {
            var result = await _worker.Employees.GetAll();
            return _mapper.Map<IList<Employee>, IList<EmployeeDTO>>(result);
        }

        public async Task<IList<EmployeeDTO>> Find(string name)
        {
            var query = await _worker.Employees.GetAll();
            var list = query.Where(c => c.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return _mapper.Map<IList<Domain.Employee>, IList<EmployeeDTO>>(list);
        }

        public async Task<string> AddEmployee(Account obj)
        { 
            var emp = _mapper.Map<Account>(obj);
            emp.Password = _encrypt.Encrypt("welcome");
            await _worker.Accounts.Add(emp);
            await _worker.Commit();
            return "ok";
        }

        public async Task<string> UpdateEmployee(Employee obj)
        {
            var emp = await _worker.Employees.Get(x => x.Id == obj.Id);
            
            emp.Name = obj.Name;
            emp.Birthday = obj.Birthday;
            emp.PhoneNumber = obj.PhoneNumber;
            emp.Address = obj.Address;
            emp.Email = obj.Email;
            emp.Gender = obj.Gender;
            emp.Status = obj.Status;

            await _worker.Employees.Update(emp);
            await _worker.Commit();
            return "Sửa thành công";
        }
    }
}