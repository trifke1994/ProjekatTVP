using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektniZadatakTVP.Classes
{
    class Slika
    {
        public string  NazivSlike { get; set; }
        public string PutanjaDoSlike { get; set; }
        public int? idKategorije { get; set; }
        public int? idAutora { get; set; }
        public  int id;

        public Slika(int idd,string naziv,string putanja,int? idkategorije,int? idautora)
        {
            id = idd;
            NazivSlike = naziv;
            PutanjaDoSlike = putanja;
            idKategorije = idkategorije;
            idAutora = idautora;
        }

        public Slika()
        {

        }
    }
}
