using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmDetaljiKorisnici : Form
    {
        APIService korisniciService = new APIService("Korisnici");
        APIService ulogeService = new APIService("Uloge");

        private Model.Korisnici _korisnik;

        public frmDetaljiKorisnici(Model.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmDetaljiKorisnici_Load(object sender, EventArgs e)
        {
            //await LoadUloge();

            if(_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtEmail.Text = _korisnik.Email;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;
                cbStatus.Checked = _korisnik.Status.GetValueOrDefault(false);
            }
        }

        private async Task LoadUloge()
        {
            var uloge = await ulogeService.Get<List<Model.Uloge>>(null);
            clbUloge.DataSource = uloge;
            //clbUloge.
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if(_korisnik == null)
            {
                var ulogeList = clbUloge.CheckedItems.Cast<Uloge>();
                var ulogeIdList = ulogeList.Select(x => x.UlogaId).ToList();

                KorisniciInsertRequest request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text,
                    Status = cbStatus.Checked,
                    Uloge = ulogeIdList
                };

                var korisnik = await korisniciService.Insert<Model.Korisnici>(request);
            }

            else
            {

            }
        }
    }
}
