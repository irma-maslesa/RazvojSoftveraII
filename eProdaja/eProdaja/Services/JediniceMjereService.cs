using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;

namespace eProdaja.Services
{
    public class JediniceMjereService : BaseReadService<Model.JediniceMjere, Database.JediniceMjere, object>, IJediniceMjereService
    {
        //public eProdajaContext _context { get; set; }
        //protected readonly IMapper _mapper;

        public JediniceMjereService(eProdajaContext context, IMapper mapper): base(context, mapper)
        {
            //_context = context;
            //_mapper = mapper;
        }

        //public IEnumerable<Model.JediniceMjere> Get()
        //{
        //    return _context.JediniceMjeres.ToList().Select(jm => _mapper.Map<Model.JediniceMjere>(jm)).ToList();
        //}

        //public Model.JediniceMjere GetById(int id)
        //{
        //    return _mapper.Map<Model.JediniceMjere>(_context.JediniceMjeres.Find(id));
        //}
    }
}
