using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class ReceiptDetailRepository : GenericRepository<ReceiptDetail>, IReceiptDetailRepository
    {
        public ReceiptDetailRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<ReceiptDetail> Get(Expression<Func<ReceiptDetail, bool>> predicate)
        {
            return await Context.ReceiptDetails
                .Include(l => l.Rooms)
                .Include(e => e.Receipt)
                .Include(j => j.Customers)
                .ThenInclude(y => y.Customer)
                .Include(b => b.Services)
                .ThenInclude(h => h.Service)
                .FirstAsync(predicate);
        }
    }
}