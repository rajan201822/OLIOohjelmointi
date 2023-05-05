﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        private string Nimi { get; set; }

        private string OpiskelijaID { get; set; }

        private int Opintopisteet { get; set; }

        //konstruktori opsikelija -luokalle 
        public Opiskelija(string _nimi, string _id, int _op)
        {
            Nimi = _nimi;
            OpiskelijaID = _id;
            Opintopisteet = _op;

        }

        public void TulostaData()
        {
            Console.WriteLine("");
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("- - Nimi: " + Nimi);
            Console.WriteLine("- - Opiskelijan ID " + OpiskelijaID);
            Console.WriteLine("- - Opintopisteet: " + Opintopisteet);
            Console.WriteLine("");
        }

        //metodi, joka ottaa parametriksi integer - arvon.
        public void Muokkaaopintopisteitä(int i)
        {
            Opintopisteet += i; 

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0; 
            }



        }
        
    }
}
