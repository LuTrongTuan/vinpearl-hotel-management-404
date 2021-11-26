using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HotelManagement.Application.Contracts.Ultilities;

namespace HotelManagement.Application.Utilities
{
    public class ManyToManyHandler<TDestination, TSource> : IManyToManyHandle<TDestination, TSource>
        where TDestination : class, new()
        where TSource : class, new()
    {
        private readonly IMapper _mapper;

        public ManyToManyHandler(IMapper mapper) => _mapper = mapper;

        public IList<TDestination> Handle<TTable>(IEnumerable<TSource> sources)
            where TTable : class
        {
            var respone = new List<TTable>();

            foreach (var data in sources)
            {
                var stuff = _mapper.Map<TDestination>(data);
                respone.Add(_mapper.Map<TTable>(stuff));
            }

            return sources
                .Select(data => _mapper.Map<TTable>(data))
                .Select(stuff => _mapper.Map<TDestination>(stuff))
                .ToList();
        }
    }
}