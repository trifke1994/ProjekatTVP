using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ProjektniZadatakTVP.Classes
{
    class Utils
    {
        public Utils()
        {
        }

        public static bool UpisiUFajl(string putanja,object ObjekatZaCuvanje)
        {
            try
            {
                Stream stream = new FileStream(putanja, FileMode.Append);
                using (BinaryWriter fs = new BinaryWriter(stream))
                {
                    fs.Write(ObjekatZaCuvanje.ToString());
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<string> CitajIzFajla(string putanja)
        {
            List<string> temp = new List<string>();
            using (StreamReader sr = new StreamReader(putanja))
            {
                while (sr.EndOfStream)
                {
                    temp.Add(sr.ReadLine());
                }
                               
            }
            return temp;
        }
    }
}
