using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosudbaKnjigaIvanMočilac20122012
{
    class Posudba
    {
        DateTime datum_posudbe_vracanja;
        int ID_knjige;
        int ID_korisnika;
        bool Vracanje;

        public Posudba(DateTime datum_posudbe_vracanja, int iD_knjige, int iD_korisnika, bool vracanje = false)
        {
            this.datum_posudbe_vracanja = datum_posudbe_vracanja;
            ID_knjige = iD_knjige;
            ID_korisnika = iD_korisnika;
            Vracanje = vracanje;
        }

        public DateTime Datum_posudbe_vracanja { get => datum_posudbe_vracanja; set => datum_posudbe_vracanja = value; }
        public int ID_knjige1 { get => ID_knjige; set => ID_knjige = value; }
        public int ID_korisnika1 { get => ID_korisnika; set => ID_korisnika = value; }
        public bool Vracanje1 { get => Vracanje; set => Vracanje = value; }
    }
}
