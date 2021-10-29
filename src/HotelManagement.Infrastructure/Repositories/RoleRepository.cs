using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepostiory
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}