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
    //[ApiController]
    //[Route("[controller/]")]
    public class JediniceMjereController : BaseReadController<Model.JediniceMjere, object>
    {
        //public IJediniceMjereService _jediniceMjereService { get; set; }

        public JediniceMjereController(IJediniceMjereService jediniceMjereService): base(jediniceMjereService)
        {
            //_jediniceMjereService = jediniceMjereService;
        }

        //[HttpGet]
        //public IEnumerable<Model.JediniceMjere> Get()
        //{
        //    return _jediniceMjereService.Get();
        //}

        //[HttpGet("{id}")]
        //public Model.JediniceMjere GetById(int id)
        //{
        //    return _jediniceMjereService.GetById(id);
        //}
    }
}
