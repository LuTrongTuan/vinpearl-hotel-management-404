using HotelManagement.Application.Contracts.Infrastructure;
using HotelManagement.Domain;

namespace HotelManagement.Infrastructure.Repositories
{
    public class ServiceReceiptRepository : GenericRepository<ServiceReceipt>, IServiceReceiptRepository
    {
        public ServiceReceiptRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}