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
    public partial class NovaPosudba : Form
    {
        static List<Posudba> PosudbaVracanjeList = new List<Posudba>();
        static string pathdocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string xmlfile = "NovaPosudba.xml";
        static string path = Path.Combine(pathdocuments, xmlfile);

        public NovaPosudba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vrijeme = vrijemePosudbe.Value;
            var datum = vrijeme.Date;

            DialogResult dialogResult = MessageBox.Show("Želite li napraviti novu posudbu?", "Upit", MessageBoxButtons.YesNo);
            Posudba PosudbaVracanje = new Posudba(datum, Convert.ToInt32(txtKnjiga.Text), Convert.ToInt32(txtKorisnik.Text), checkBoxVracanje.Checked);
            PosudbaVracanjeList.Add(PosudbaVracanje);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var PosudbaVracanja = XDocument.Load(path);
                    foreach (Posudba posudbavracanje in PosudbaVracanjeList)
                    {
                        if (posudbavracanje.Vracanje1 == true)
                        {
                            var posudbavracanjeXML = new XElement("Vracanje",
                            new XElement("Vracanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ID_knjige1),
                            new XElement("Korisnik", posudbavracanje.ID_korisnika1));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                        else
                        {
                            var posudbavracanjeXML = new XElement("Posudivanje",
                            new XElement("Posudivanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ID_knjige1),
                            new XElement("Korisnik", posudbavracanje.ID_korisnika1));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                    }
                    PosudbaVracanja.Save(path);
                }
                catch (Exception ex)
                {
                    var PosudbaVracanja = new XDocument();
                    PosudbaVracanja.Add(new XElement("PosudivanjaVracanja"));
                    foreach (Posudba posudbavracanje in PosudbaVracanjeList)
                    {
                        if (posudbavracanje.Vracanje1 == true)
                        {
                            var posudbavracanjeXML = new XElement("Vracanje",
                            new XElement("Vracanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ID_knjige1),
                            new XElement("Korisnik", posudbavracanje.ID_korisnika1));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                        else
                        {
                            var posudbavracanjeXML = new XElement("Posudivanje",
                            new XElement("Posudivanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ID_knjige1),
                            new XElement("Korisnik", posudbavracanje.ID_korisnika1));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                    }
                    PosudbaVracanja.Save(path);
                }
            }
        }
    }
    }

