using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakTVP.Classes
{
    class Autor
    {
        public string ImePreizime { get; set; }
        public DateTime GodinaRodjenja { get; set; }
        private static int id;

        public Autor(string imePrezime,DateTime godinaRodjenja)
        {
            id++;
            ImePreizime = imePrezime;
            GodinaRodjenja = godinaRodjenja;
        }

        public override string ToString()
        {
            return id + " " + ImePreizime + " " + GodinaRodjenja;
        }
    }
}
