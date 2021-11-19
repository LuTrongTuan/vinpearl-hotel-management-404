using System.Collections.Generic;
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

        public async Task<CustomerDTO> GetDetail(string id)
        {
            var query = await _worker.Customers.Get(x => x.IdentityNumber == id);
            return _mapper.Map<CustomerDTO>(query);
        }

        public async Task Add(CustomerDTO customer)
        {
            var query = await _worker.Customers.Get(x => x.IdentityNumber == customer.IdentityNumber);
            if(query is not null)
                return;
            var user = _mapper.Map<Customer>(customer);
            await _worker.Customers.Add(user);
            await _worker.Commit();
        }

        public async Task Update(CustomerDTO customer)
        {
            var user = await _worker.Customers.Get(x => x.IdentityNumber == customer.IdentityNumber);
            if (user is null)
                return;
            user.Name = customer.Name;
            user.IdentityNumber = customer.IdentityNumber;
            user.Gender = customer.Gender;
            user.PhoneNumber = customer.PhoneNumber;
            await _worker.Customers.Update(user);
            await _worker.Commit();
        }

        public async Task<IList<CustomerDTO>> GetList()
        {
            var query = await _worker.Customers.GetAll();
            return _mapper.Map<IList<Customer>, IList<CustomerDTO>>(query);
        }
    }
}