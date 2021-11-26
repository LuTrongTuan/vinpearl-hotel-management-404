using System.Collections.Generic;

namespace HotelManagement.Application.Contracts.Ultilities
{
    public interface IManyToManyHandle<TDestination, in TSource>
    {
        public IList<TDestination> Handle<TTable>(IEnumerable<TSource> sources) where TTable : class;
    }
}