using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService:IProizvodService
    {
        private static List<Proizvod> _proizvodi;

        static ProizvodService()
        {
            _proizvodi = new List<Proizvod>();

            _proizvodi.Add(new Proizvod() { Id = 1, Name = "Laptop" });
            _proizvodi.Add(new Proizvod() { Id = 2, Name = "Miš" });
        }

        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }
        public Proizvod GetById(int id)
        {
            return _proizvodi.FirstOrDefault(p => p.Id == id);
        }
        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod);

            return proizvod;
        }
        public Proizvod Update(Proizvod proizvod, int id)
        {
            var _proizvod = _proizvodi.FirstOrDefault(p => p.Id == id);

            if (_proizvod != null)
                _proizvod.Name = proizvod.Name;

            return _proizvod;
        }
    }
}
