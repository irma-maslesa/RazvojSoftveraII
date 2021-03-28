using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;

namespace eProdaja.Services
{
    public class VrsteProizvodaService : /*IVrsteProizvodaService*/ BaseReadService<Model.VrsteProizvodum, Database.VrsteProizvodum, object>, IVrsteProizvodaService
    {
        //public eProdajaContext _context { get; set; }
        //protected readonly IMapper _mapper;

        public VrsteProizvodaService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            //_context = context;
            //_mapper = mapper;
        }

        //    public IEnumerable<Model.VrsteProizvodum> Get()
        //    {
        //        return _context.VrsteProizvoda.ToList().Select(vp => _mapper.Map<Model.VrsteProizvodum>(vp)).ToList();
        //    }
        //    public Model.VrsteProizvodum GetById(int id)
        //    {
        //        return _mapper.Map<Model.VrsteProizvodum>(_context.VrsteProizvoda.Find(id));
        //    }
    }
}
