using System.Threading.Tasks;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IReceiptDetailRepository : IGenericRepository<ReceiptDetail>
    {
    }
}