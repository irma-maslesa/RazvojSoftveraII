using eProdaja.Database;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class UlogeController : BaseReadController<Model.Uloge, object>
    {
        public UlogeController(IReadService<Model.Uloge, object> ulogeService): base(ulogeService)
        {
        }
    }
}
