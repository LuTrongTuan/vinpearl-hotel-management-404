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
            var lst = _mapper.Map<IList<Employee>, IList<EmployeeDTO>>(result);
            for(var i = 0; i < result.Count; i++)
            {
                var acc = await _worker.Accounts.Get(x => x.EmployeeId == result[i].Id);
                var role = await _worker.Roles.Get(x => x.Id == acc.RoleId);
                lst[i].NameRole = role.Name;
            }

            return lst;
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
            return "Ok";
        }

        public async Task<string> UpdateEmployee(EmployeeDTO obj)
        {
           _employee = await _worker.Employees.Get(x => x.Id == obj.Id);

           _employee.Name = obj.Name;
           _employee.Birthday = obj.Birthday;
            _employee.PhoneNumber = obj.PhoneNumber;
            _employee.Address = obj.Address;
            _employee.Email = obj.Email;
            _employee.Gender = obj.Gender;
            _employee.Status = obj.Status;

            await _worker.Employees.Update(_employee);
            await _worker.Commit();
            return "Sửa thành công";
        }
        
        public async Task<IList<EmployeeDTO>> Get()
        {
            var query = await _worker.Employees.GetAll();
            return _mapper.Map<IList<Employee>, IList<EmployeeDTO>>(query);
        }
    }
}