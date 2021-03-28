using eProdaja.Model;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseReadController<Proizvodi, ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService)
        {
        }
    }
}
