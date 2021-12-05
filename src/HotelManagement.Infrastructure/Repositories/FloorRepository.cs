using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class FloorRepository : GenericRepository<Floor>, IFloorRepository
    {
        public FloorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<IList<Floor>> GetAll()
        {
            return await Context.Floors
                .Include(e => e.Rooms.OrderBy(d => d.Name))
                .ThenInclude(m => m.Type)
                .ToListAsync();
        }
    }
}