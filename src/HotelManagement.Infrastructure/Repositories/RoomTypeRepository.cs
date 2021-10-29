using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository

    {
        public RoomTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}