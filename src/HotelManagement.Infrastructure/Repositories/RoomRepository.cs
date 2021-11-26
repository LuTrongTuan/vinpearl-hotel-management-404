using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<string> GetLastRoomName(string floor)
        {
            string result;
            try
            {
                result = Context.Rooms
                    .Where(x => x.Name.Contains(floor))
                    .OrderByDescending(x => x.Name).First()
                    .Name;
            }
            catch
            {
                result = "P00";
            }
            return Task.FromResult(result);
        }

        public override async Task<Room> Get(Expression<Func<Room, bool>> predicate)
        {
            return await Context.Rooms
                .Include(e => e.Type)
                .FirstOrDefaultAsync(predicate);
        }
    }
}