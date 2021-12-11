using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelManagement.Domain;

namespace HotelManagement.Application.Contracts.Infrastructure
{
    public interface IReceiptDetailRepository : IGenericRepository<ReceiptDetail>
    {
        Task<int> GetCurrentRentType(Expression<Func<ReceiptDetail, bool>> predicate);
        Task<IList<ReceiptDetail>> getTak(Expression<Func<ReceiptDetail, bool>> predicate);
    }
}