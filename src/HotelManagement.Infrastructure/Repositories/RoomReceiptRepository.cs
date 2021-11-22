using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomReceiptRepository : GenericRepository<RoomReceipt>, IRoomReceiptRepository
    {
        public RoomReceiptRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<RoomReceipt> Get(Expression<Func<RoomReceipt, bool>> predicate)
        {
            return await Context.RoomReceipts
                .Include(e => e.Histories)
                .OrderBy(x => x.CreateAt)
                .LastAsync(predicate);
        }
    }
}