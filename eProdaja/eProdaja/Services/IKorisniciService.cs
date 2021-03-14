using eProdaja.Model.Requests;
using System.Collections.Generic;

namespace eProdaja.Services
{
    public interface IKorisniciService
    {
        public IEnumerable<Model.Korisnici> Get();
        public Model.Korisnici GetById(int id);
        Model.Korisnici Insert(KorisniciInsertRequest request);

    }
}
