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
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>().ReverseMap();
            CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>().ReverseMap();
            CreateMap<Database.Proizvodi, Model.Proizvodi>().ReverseMap();
            CreateMap<Model.Proizvodi, Database.Proizvodi>().ReverseMap();
            CreateMap<Model.Uloge, Database.Uloge>().ReverseMap();

            CreateMap<Model.Requests.ProizvodiInsertRequest, Database.Proizvodi> ().ReverseMap();
            CreateMap<Model.Requests.ProizvodiUpdateRequest, Database.Proizvodi>().ReverseMap();
        }
    }
}
