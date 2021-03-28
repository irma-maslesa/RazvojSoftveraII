using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    //TDb - tabela iz baze
    //T - model
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T: class where TDb: class where TSearch : class
    {
        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService (eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            return _mapper.Map<List<T>>(_context.Set<TDb>().ToList());
        }
        public virtual T GetById(int id)
        {
            return _mapper.Map<T>(_context.Set<TDb>().Find(id));
        }
    }
}
