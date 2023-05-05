//harjoitus2
using Harjoitus2;

internal class Program
{
    private static void Main(string[] args)
    {
        //luodaan opiskelija olio 
        Opiskelija opiskelija1 = new Opiskelija("Matti", "TVT1234", 0);

        opiskelija1.TulostaData();
        opiskelija1.Muokkaaopintopisteitä(5);
        opiskelija1.TulostaData();
            
    }
}