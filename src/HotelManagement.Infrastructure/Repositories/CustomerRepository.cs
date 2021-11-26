using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<Customer> Get(Expression<Func<Customer, bool>> predicate)
        {
            return await Context.Customers
                .Include(x => x.Identification)
                .FirstOrDefaultAsync(predicate);
        }
    }
}