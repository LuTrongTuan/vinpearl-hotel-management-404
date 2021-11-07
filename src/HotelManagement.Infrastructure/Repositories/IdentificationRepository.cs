using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class IdentificationRepository : GenericRepository<Identification>, IIdentificationRepository
    {
        protected IdentificationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}