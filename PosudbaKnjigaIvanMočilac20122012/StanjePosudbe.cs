using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class StanjePosudbe : Form
    {
        static string pathdocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string posudbavracanje = "NovaPosudba.xml";
        static string pathposudbavracanje = Path.Combine(pathdocuments, posudbavracanje);
        static string korisnici = "Korisnici.xml";
        static string pathkorisnici = Path.Combine(pathdocuments, korisnici);
        static string knjige = "Knjige.xml";
        static string pathknjige = Path.Combine(pathdocuments, knjige);

        public StanjePosudbe()
        {
            InitializeComponent();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
            var Knjige = XDocument.Load(pathknjige);
            var Korisnici = XDocument.Load(pathkorisnici);
            var PosudbaVracanje = XDocument.Load(pathposudbavracanje);
                IEnumerable<string> ListaOIBa = from s in Korisnici.Descendants("Korisnik")
                                              where s.Element("OIB").Value == txtKorisnik.Text
                                              select "OIB: " + s.Element("OIB").Value +
                                                     "\nIme: " + s.Element("Ime").Value +
                                                     "\nPrezime: " + s.Element("Prezime").Value + "\n\n";
                foreach (string s in ListaOIBa) { txtPretraga.Text += s; }

                IEnumerable<string> ListaISBNa = from s in Knjige.Descendants("Knjiga")
                                               where s.Element("ISBN").Value == txtKnjiga.Text
                                               select "ISBN: " + s.Element("ISBN").Value +
                                                      "\nNaziv: " + s.Element("Naziv").Value +
                                                      "\nAutor: " + s.Element("Autor").Value +"\n\n";
                foreach (string s in ListaISBNa) { txtPretraga.Text += s; }

                IEnumerable<string> ListaVracanja = from s in PosudbaVracanje.Descendants("Vracanje")
                                                   where s.Element("Knjiga").Value == dateDatumPosudbe.Text
                                                   select "Datum Vracanja: " + s.Element("VracanjeDatum").Value +
                                                          "\nOIB: " + s.Element("Korisnik").Value +
                                                          "\nISBN: " + s.Element("Knjiga").Value + "\n\n";
                foreach (string s in ListaVracanja) { txtPretraga.Text += s; }
            }
        }
    }

