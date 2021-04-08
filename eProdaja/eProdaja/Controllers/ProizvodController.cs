using eProdaja.Models;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProizvodController : ControllerBase
    {
        public IProizvodService _proizvodService { get; set; }

        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }

        [HttpGet]
        public IEnumerable<Proizvod> Get()
        {
            return _proizvodService.Get();
        }

        [HttpGet("{id}")]
        public Proizvod GetById(int id)
        {
            return _proizvodService.GetById(id);
        }

        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {
            return _proizvodService.Insert(proizvod);
        }

        [HttpPut("{id}")]
        public Proizvod Update(Proizvod proizvod, int id)
        {
            return _proizvodService.Update(proizvod, id);
        }
        
    }
}
