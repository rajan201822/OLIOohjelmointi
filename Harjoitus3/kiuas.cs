using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3KT
{
    internal class kiuas
    {
        public string Nimi;

        public int Lämpotila;

        public int Kosteus;

        public bool Päällä;

        public kiuas(string _nimi, int _lämpötila, int _kosteus, bool _päällä)
        {
            Nimi = _nimi;
            Lämpotila = _lämpötila;
            Kosteus = _kosteus;
            Päällä = _päällä;
            
          
        }

        public void päälle()
        {
            if (Päällä)
            {
                Päällä = false;
            }

            else
            {
                Päällä = true; 
            }
        }
        public void Lämpötilaylös()
        {
            Console.WriteLine("syötä lämpötila");
            Lämpotila=int.Parse(Console.ReadLine());
        }

        public void kosteus()
        {
            Console.WriteLine("syötä kiukkaan kosteus");
            Kosteus = int.Parse(Console.ReadLine());
        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("kiuas: ");
            Console.WriteLine("- - Nimi: " + Nimi);
            if (Päällä)
            {
                Console.WriteLine("kiuas on päällä") ; 

            }
            else
            {
                Console.WriteLine("kiuas ei ole päällä");
            }
            Console.WriteLine("- - Lämpötila " + Lämpotila);
            Console.WriteLine("- - kosteus " + Kosteus);
            Console.WriteLine("- - päällä " );
            Console.WriteLine("");
        }
    }
}
