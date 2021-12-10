using System;
using System.Collections.Generic;
using System.Linq;
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
                .Include(e => e.Receipt)
                .Include(j => j.Customers)
                .ThenInclude(y => y.Customer)
                .Include(b => b.Services)
                .ThenInclude(h => h.Service)
                .Include(k => k.Histories)
                .OrderBy(x => x.CreateAt)
                .LastAsync(predicate);
        }

        public async Task<int> GetCurrentRentType(Expression<Func<ReceiptDetail, bool>> predicate)
        {
            var history = await Context.ReceiptDetails
                .Include(d => d.Histories)
                .OrderBy(x => x.CreateAt)
                .LastAsync(predicate);
            return history.Histories.Last().Status;
        }

        public async Task<IList<ReceiptDetail>> getTak(Expression<Func<ReceiptDetail, bool>> predicate)
        {
            return await Context.ReceiptDetails

                .Include(e => e.Receipt)
                .Where(predicate).ToListAsync();
        }
    }
}