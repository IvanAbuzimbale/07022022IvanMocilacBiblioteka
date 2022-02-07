using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class UpisKorisnika : Form
    {
        List<Korisnici> listaKorisnika = new List<Korisnici>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Korisnici.xml");
        public UpisKorisnika()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string poruka = "Želite li dodati novog korisnika?";
            string naslov = "Upit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);
            
            Korisnici upiskorisnika = new Korisnici(txtOIB.Text, txtIme.Text, txtPrezime.Text);
            listaKorisnika.Add(upiskorisnika);

            if (Regex.IsMatch(txtOIB.Text, @"^\d+$") & txtOIB.TextLength < 12)
            {
                if (rez == DialogResult.No)
                {
                    try
                    {
                        var Korisnici = XDocument.Load(putanja);
                        foreach (Korisnici korisnik in listaKorisnika)
                        {
                            var Korisnik = (new XElement("Korisnik",
                            new XElement("OIB", korisnik.Id),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime)));
                            Korisnici.Root.Add(Korisnik);
                        }
                        Korisnici.Save(putanja);
                    }
                    catch (Exception ex)
                    {
                        var Korisnici = new XDocument();
                        Korisnici.Add(new XElement("Korisnici"));
                        foreach (Korisnici korisnik in listaKorisnika)
                        {
                            var Korisnik = new XElement("Korisnik",
                            new XElement("OIB", korisnik.Id),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime));
                            Korisnici.Root.Add(Korisnik);
                        }
                        Korisnici.Save(putanja);
                    }
                    listaKorisnika.Clear();
                    this.Close();
                }
            }
            else
            {
                string poruka1 = "Molimo da upišete pravilan OIB.";
                string naslov1 = "Greška";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                MessageBoxIcon ikona1 = MessageBoxIcon.Error;
                DialogResult rez1 = MessageBox.Show(poruka1, naslov1, buttons1, ikona1);
            }
        }
    }
}
