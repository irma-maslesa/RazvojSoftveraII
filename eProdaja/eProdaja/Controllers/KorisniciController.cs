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
    [ApiController]
    [Route("api/[controller]")]
    public class KorisniciController : ControllerBase
    {
        public IKorisniciService _korisniciService { get; set; }

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get(KorisniciSearchRequest search)
        {
            return _korisniciService.Get(search);
        }

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _korisniciService.GetById(id);
        }

        [HttpPost]
        public Model.Korisnici Insert([FromBody] KorisniciInsertRequest request)
        {
            return _korisniciService.Insert(request);
        }
    }
}
