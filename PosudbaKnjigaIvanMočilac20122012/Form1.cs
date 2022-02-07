using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            UpisKorisnika korisnik = new UpisKorisnika();
            korisnik.Show();
        }

        private void btnNovaKnjiga_Click(object sender, EventArgs e)
        {
            NovaKnjiga novaKnjiga = new NovaKnjiga();
            novaKnjiga.Show();
        }

        private void btnNovaPosudba_Click(object sender, EventArgs e)
        {
            NovaPosudba novaPosudba = new NovaPosudba();
            novaPosudba.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            StanjePosudbe stanjePosudbe = new StanjePosudbe();
            stanjePosudbe.Show();
        }
    }
}
