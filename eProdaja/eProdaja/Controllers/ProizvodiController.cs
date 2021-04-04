using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : //BaseReadController<Proizvodi, ProizvodiSearchObject>
        BaseCRUDController<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService)
        {
        }
    }
}
