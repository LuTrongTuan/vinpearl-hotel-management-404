using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IReceiptDetailRepository : IGenericRepository<ReceiptDetail>
    {
        Task<int> GetCurrentRentType(Expression<Func<ReceiptDetail, bool>> predicate);
    }
}