using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakTVP.Classes
{
    class Ocena
    {
        public int idSlike { get; set; }
        public int OcenaSlike { get; set; }
        public DateTime DatumOcene { get; set; }


        public Ocena(int idslike,int ocena,DateTime datum)
        {
            idSlike = idslike;
            OcenaSlike = ocena;
            DatumOcene= datum;
        }
    }
}
