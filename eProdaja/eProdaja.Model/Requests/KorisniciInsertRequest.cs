using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Ime { get; set; }
        [MinLength(3)]
        [MaxLength(20)]
        public string Prezime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Lozinka { get; set; }

        public bool Status { get; set; }
        public List<int> Uloge { get; set; }
    }
}
