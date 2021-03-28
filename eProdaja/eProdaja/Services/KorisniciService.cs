using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using eProdaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;

        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Korisnici> Get()
        {
            return _context.Korisnicis.ToList().Select(k => _mapper.Map<Model.Korisnici>(k)).ToList();
        }
        public Model.Korisnici GetById(int id) 
        {
            return _mapper.Map<Model.Korisnici>(_context.Korisnicis.FirstOrDefault(k => k.KorisnikId == id));
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            /* var korisnik = new Korisnici
            {

            };

            //_context.Add(korisnik);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(korisnik);*/

            //throw new NotImplementedException();

            throw new UserException("Neispravna lozinka");
        }
    }
}
