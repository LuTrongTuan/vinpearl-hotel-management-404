using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace HotelManagement.Application.Utilities
{
    public class NToN<TSource, TDestination>
        where TDestination : class, new()
        where TSource : class, new()
    {
        private readonly IMapper _mapper;
        private event Func<TSource, Task<int>> IsExist;

        public NToN(IMapper mapper, Func<TSource, Task<int>> isExist)
        {
            _mapper = mapper;
            IsExist = isExist;
        }


        public async Task<IList<TTable>> Handle<TTable>(IEnumerable<TSource> sources, string key, string navigationProp)
            where TTable : class
        {
            var result = new List<TTable>();
            foreach (var data in sources)
            {
                var instance = Activator.CreateInstance<TTable>();
                try
                {
                    if (IsExist != null)
                    {
                        var temp = await IsExist.Invoke(data);
                        var id = Convert.ToInt32(temp);
                        if (id == default)
                            throw new Exception();
                        CopyValue(ref instance, id, key);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    var stuff = _mapper.Map<TDestination>(data);
                    CopyValue(ref instance, stuff, navigationProp);
                }
                finally
                {
                    result.Add(instance);
                }
            }

            return result;
        }

        public IList<TDestination> Get<TTable>(IEnumerable<TTable> source, string prop)
        {
            return source
                .Select(entity => entity.GetType().GetProperty(prop)?.GetValue(entity))
                .Select(data => _mapper.Map<TDestination>(data))
                .ToList();
        }
        private void CopyValue<TType>(ref TType destination, object source, string key)
        {
            try
            {
                var prop = destination.GetType().GetProperty(key);
                prop?.SetValue(destination, source);
            }
            catch (Exception e)
            {
                throw new Exception(key + " not found. " + e.Message);
            }
        }
    }
}