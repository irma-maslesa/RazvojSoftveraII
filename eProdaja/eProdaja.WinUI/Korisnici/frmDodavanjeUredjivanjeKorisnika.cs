using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI.Korisnici
{
    public partial class frmDodavanjeUredjivanjeKorisnika : Form
    {
        public frmDodavanjeUredjivanjeKorisnika()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //Bolja opcija - resursi
            //errorProvider.SetError(txtIme, "Polje je obavezno");

            errorProvider.SetError(txtIme, Properties.Resources.ObaveznoPolje);
        }
    }
}
