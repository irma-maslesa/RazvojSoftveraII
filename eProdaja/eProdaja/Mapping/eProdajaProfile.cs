using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Mapping
{
    public class eProdajaProfile : Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Model.Proizvodi, Database.Proizvodi>();
            CreateMap<Model.Requests.ProizvodiInsertRequest, Database.Proizvodi> ();
            CreateMap<Model.Requests.ProizvodiUpdateRequest, Database.Proizvodi>();
        }
    }
}
