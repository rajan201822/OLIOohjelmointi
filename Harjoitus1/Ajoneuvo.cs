using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        public string Nimi { get; set; }

        public int Nopeus { get; set; } 

        public int Renkaat { get; set; } 

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("- - Nimi: " + Nimi);
            Console.WriteLine("- - Nopeus: " + Nopeus);
            Console.WriteLine("- - Renkaat: " + Renkaat);
        }

        public String ToString()
        {
            string merkkijono = "Ajoneuvo Nimi: " + Nimi + ". Nopeus: " + Nopeus + " km/h Renkaat: " + Renkaat + "kpl "; 
            
            return merkkijono; 
        }
    }
}
