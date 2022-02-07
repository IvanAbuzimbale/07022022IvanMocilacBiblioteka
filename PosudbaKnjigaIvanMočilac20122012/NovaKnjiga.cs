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
using System.Xml;
using System.Xml.Linq;

namespace PosudbaKnjigaIvanMočilac20122012
{
    public partial class NovaKnjiga : Form
    {
        List<Knjige> listaKnjiga = new List<Knjige>();
        static string dokumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string putanja = Path.Combine(dokumenti, "Knjige.xml");

        public NovaKnjiga()
        {
            InitializeComponent();
        }

        private void btnUnesiKnjigu_Click(object sender, EventArgs e)
        {
            string poruka = "Želite li dodati novu knjigu?";
            string naslov = "Upit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);

            Knjige upisKnjiga = new Knjige(txtISBN.Text, txtNaziv.Text, txtAutor.Text);
            listaKnjiga.Add(upisKnjiga);

            if (Regex.IsMatch(txtISBN.Text, @"^\d+$") & txtISBN.TextLength < 14)
            {
                if (rez == DialogResult.No)
                {
                    try
                    {
                        var NoveKnjige = XDocument.Load(putanja);
                        foreach (Knjige knjige in listaKnjiga)
                        {
                            var Knjiga = (new XElement("Knjiga",
                            new XElement("ISBN", knjige.Isbn),
                            new XElement("Naziv", knjige.Naziv),
                            new XElement("Autor", knjige.Autor)));
                            NoveKnjige.Root.Add(Knjiga);
                        }
                        NoveKnjige.Save(putanja);
                    }
                    catch (Exception ex)
                    {
                        var NoveKnjige = new XDocument();
                        NoveKnjige.Add(new XElement("Knjige"));
                        foreach (Knjige knjige in listaKnjiga)
                        {
                            var Knjiga = (new XElement("Knjiga",
                            new XElement("ISBN", knjige.Isbn),
                            new XElement("Naziv", knjige.Naziv),
                            new XElement("Autor", knjige.Autor)));
                            NoveKnjige.Root.Add(Knjiga);
                        }
                        NoveKnjige.Save(putanja);
                    }
                    listaKnjiga.Clear();
                    this.Close();
                }
            }
            else
            {
                string poruka1 = "Molimo da upišete pravilan ISBN.";
                string naslov1 = "Greška";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                MessageBoxIcon ikona1 = MessageBoxIcon.Error;
                DialogResult rez1 = MessageBox.Show(poruka1, naslov1, buttons1, ikona1);
            }
            
        }
    }
}
