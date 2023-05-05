//harjoitus 3 (kT)

using Harjoitus3KT;

internal class Program

{
    private static void Main(string[] args)
    {
        kiuas harvi1 = new kiuas("Harvia", 0, 0, false);
        harvi1.TulostaData();
        harvi1.päälle();
        harvi1.TulostaData();

        harvi1.Lämpötilaylös();
        harvi1.TulostaData();
        harvi1.kosteus();
        harvi1.TulostaData();
        



       

    }
}