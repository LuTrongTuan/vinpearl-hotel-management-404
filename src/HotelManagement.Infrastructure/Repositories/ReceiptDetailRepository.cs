using System.Linq;
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

        public async Task<ReceiptDetail> GetDetail(int id)
        {
            var roomReceipt = await Context.RoomReceipts.FirstAsync(x => x.RoomId == id);
            var query = await Context.ReceiptDetails
                .Include(e => e.Receipt)
                .ThenInclude(d => d.Customer)
                .Include(j => j.ServiceReceipts)
                .ThenInclude(h => h.Service)
                .OrderBy(q => q.CheckIn)
                .LastAsync(x => x.Id == roomReceipt.ReceiptDetailId);

            return query;
        }
    }
}