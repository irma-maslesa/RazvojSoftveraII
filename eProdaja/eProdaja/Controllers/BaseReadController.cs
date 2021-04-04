using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T: class where TSearch: class
    {
        protected readonly IReadService<T, TSearch> _readService;

        public BaseReadController(IReadService<T, TSearch> readService)
        {
            _readService = readService;
        }

        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery] TSearch search = null)
        {
            return _readService.Get(search);
        }

        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return _readService.GetById(id);
        }
    }
}
