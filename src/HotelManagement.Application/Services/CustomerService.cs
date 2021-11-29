using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Application.Contracts.Services;
using HotelManagement.Application.DTOs;
using HotelManagement.Domain;

namespace HotelManagement.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _worker;
        private readonly IMapper _mapper;

        public CustomerService(IUnitOfWork worker, IMapper mapper)
        {
            _worker = worker;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerDTO>> Get()
        {
            var query = await _worker.Customers.GetAll();
            return _mapper.Map<IList<Customer>, IList<CustomerDTO>>(query);
        }

        public async Task<IList<CustomerDTO>> Find(string name)
        {
            var cus = await _worker.Customers.GetAll();
            var list = cus.Where(c => c.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return _mapper.Map<IList<Customer>, IList<CustomerDTO>>(list);
        }

        public async Task<int> Add(CustomerDTO customer)
        {
            var user = await _worker.Customers.Get(x => x.IdentityNumber == customer.IdentityNumber);
            if (user is not null)
                return user.Id;
            var result = _mapper.Map<Customer>(customer);
            await _worker.Customers.Add(result);
            await _worker.Commit();
            return default;
        }

        public async Task Update(CustomerDTO customer)
        {
            var user = await _worker.Customers.Get(x => x.IdentityNumber == customer.IdentityNumber);
            if (user is null)
                return;
            _mapper.Map(user, customer);
            await _worker.Customers.Update(user);
            await _worker.Commit();
        }

        public async Task<int> IsExist(CustomerDTO customer)
        {
            var query = await _worker.Customers.Get(x => x.IdentityNumber == customer.IdentityNumber);
            return query?.Id ?? 0;
        }

        public async Task<IList<CustomerDTO>> GetList()
        {
            var query = await _worker.Customers.GetAll();
            return _mapper.Map<IList<Customer>, IList<CustomerDTO>>(query);
        }
        public async Task<CustomerDTO> GetDetail(string id)
        {
            var query = await _worker.Customers.Get(x => x.IdentityNumber == id);
            return _mapper.Map<CustomerDTO>(query);
        }
    }
}