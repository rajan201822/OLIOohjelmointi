//Eläinesimerkki

using Eläinesimerkki;

internal class Program
{
    private static void Main(string[] args)
    {
        Koira mopsi = new Koira();  // <--- luo uuden olion 

        //lisätään koiralle ominaisuudet 
        mopsi.Nimi = "Rekku";
        mopsi.ikä = 4;
        mopsi.rotu = "Saksanpaimenkoira";
        mopsi.väri = "Harmaa";
        mopsi.paino = 32.0f;

        //kutsutaan mopsi metodia "Hauku" 
        mopsi.hauku();

        //kirjoitetaan konsoliin mopsin tiedot 
        Console.WriteLine(mopsi.HaeTiedot());


        //haukutaan viimeisen kerran 
        mopsi.hauku();

        Console.WriteLine("Anna koiran tiedot:");
        mopsi.Nimi = Console.ReadLine();

        Console.WriteLine(mopsi.HaeTiedot());
    }
}