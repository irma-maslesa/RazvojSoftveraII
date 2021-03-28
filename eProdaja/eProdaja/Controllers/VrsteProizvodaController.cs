using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eProdaja.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    public class VrsteProizvodaController : /*ControllerBase*/ BaseReadController<Model.VrsteProizvodum, object>
    {
        //public IVrsteProizvodaService _vrsteProizvodaService { get; set; }

        public VrsteProizvodaController(IVrsteProizvodaService vrsteProizvodaService):base(vrsteProizvodaService)
        {
            //_vrsteProizvodaService = vrsteProizvodaService;
        }

        //[HttpGet]
        //public IEnumerable<Model.VrsteProizvodum> Get()
        //{
        //    //return _vrsteProizvodaService.Get();
        //}

        //[HttpGet("{id}")]
        //public Model.VrsteProizvodum GetById(int id)
        //{
        //    //return _vrsteProizvodaService.GetById(id);
        //}
    }
}
