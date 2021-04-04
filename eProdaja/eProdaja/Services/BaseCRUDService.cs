using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> :
        BaseReadService<T, TDb, TSearch>,
        ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class
        where TDb : class
        where TSearch : class
        where TInsert : class
        where TUpdate : class
    {
        public BaseCRUDService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public T Insert(TInsert request)
        {
            var set = _context.Set<TDb>();
            var entity = _mapper.Map<TDb>(request);

            set.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public T Update(int id, TUpdate request)
        {
            var set = _context.Set<TDb>();
            var entity = set.Find(id);

            _mapper.Map(request, entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
