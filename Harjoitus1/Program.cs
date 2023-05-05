//Harjoitus1

using Harjoitus1;

internal class Program
{
    private static void Main(string[] args)
    {
      Ajoneuvo auto = new Ajoneuvo();
        //asetetaan Oliolle "auto" arvot
        auto.Nimi = "Toyota";
        auto.Nopeus = 160;
        auto.Renkaat = 4;

        //käytetään "auto" olion toimintoja 
        auto.TulostaData(); 
      
        //Noudetaan auton tiedot ToString metodilla()
        string autonTiedot = auto.ToString();
        Console.WriteLine(autonTiedot);

        //Tyhjä rivi konsoliin 
        Console.WriteLine(); 

        //luodaan toinen olio luokasta ajoneuvo 

        Ajoneuvo mopo = new Ajoneuvo();
        mopo.Nimi = "Skootteri";
        mopo.Nopeus = 55; 
        mopo.Renkaat = 2;

        mopo.TulostaData(); 
        Console.Write(mopo.ToString()); 

    }

    
}