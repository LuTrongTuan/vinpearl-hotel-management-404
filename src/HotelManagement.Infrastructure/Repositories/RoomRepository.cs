using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}