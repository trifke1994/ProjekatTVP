using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakTVP.Classes
{
    class Kategorija
    {
        public string NazivKategorije { get; set; }
        private static int id;

        public Kategorija(string naziv)
        {
            id++;
            NazivKategorije = naziv;
        }
    }
}
