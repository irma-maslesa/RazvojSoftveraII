using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodService
    {
        public IEnumerable<Proizvod> Get();
        public Proizvod GetById(int id);
        public Proizvod Insert(Proizvod proizvod);
        public Proizvod Update(Proizvod proizvod, int id);
    }
}
