using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomReceiptRepository : GenericRepository<RoomReceipt>, IRoomReceiptRepository
    {
        public RoomReceiptRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}