using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class ReceiptDetailRepository : GenericRepository<ReceiptDetail>, IReceiptDetailRepository
    {
        public ReceiptDetailRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}