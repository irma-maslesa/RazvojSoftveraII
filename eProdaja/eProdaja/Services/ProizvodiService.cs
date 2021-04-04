using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using eProdaja.Model.Requests;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : 
        //BaseReadService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject>, IProizvodiService
        BaseCRUDService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, 
        IProizvodiService
    {
        public ProizvodiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = _context.Set<Database.Proizvodi>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
                entity = entity.Where(x => x.Naziv.ToLower().Contains(search.Naziv.ToLower()));

            if (search.JedinicaMjereId.HasValue)
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);

            if (search.VrstaId != null)
                entity = entity.Where(x => x.VrstaId == search.VrstaId);

            //bad practice
            //if (search.IncludeJedinicaMjere == true)
            //    entity = entity.Include(x => x.JedinicaMjere);

            //bad practice
            //if (search.IncludeJedinicaMjere == true)
            //    //naziv propertija iz DB objekta
            //    entity = entity.Include("JedinicaMjere");

            //best practice
            if (search?.IncludeList?.Any() == true)
                foreach (var item in search.IncludeList)
                    entity = entity.Include(item);
            

            //ToList - obavezno na kraju zbog načina izvršenja
            return _mapper.Map<List<Model.Proizvodi>>(entity.ToList());
        }
    }
}
