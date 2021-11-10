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

        public async Task<CustomerDTO> GetDetail(int id)
        {
            var query = await _worker.Customers.Get(x => x.Id == id);
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
    }
}