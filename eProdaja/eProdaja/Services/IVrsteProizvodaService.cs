using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;

namespace eProdaja.Services
{
    public interface IVrsteProizvodaService: IReadService<VrsteProizvodum, object>
    {
        //public IEnumerable<VrsteProizvodum> Get();
        //public VrsteProizvodum GetById(int id);
    }
}
