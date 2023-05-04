using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eläinesimerkki
{
    internal class Koira
    {
        public string Nimi {get; set;}
        public int ikä { get; set; }
        public string rotu { get; set; } 
        
        public string väri { get; set; }

        public float paino { get; set; }

        public string HaeTiedot() 
        {
            string merkkijono = ". Nimi: " + Nimi + ". ikä: " + ikä + ". rotu: " + rotu + ". väri: " + väri + ". paino: " + paino.ToString();
            return merkkijono; 
        }

        public void hauku() 
        {
            Console.WriteLine("Woof");
        }
    }
}
