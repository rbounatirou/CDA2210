// See https://aka.ms/new-console-template for more information
using ProductionLibrary;

public class Program
{
   

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Production prod = new Production(EnumVitesseProduction.CAISSE_A);
        prod.ProductionActuelleChanged += new Production.DelegateProduction(Program.MethodDelegate);
        prod.changerProd();
    }

    private static void MethodDelegate(Production prod)
    {
        Console.WriteLine("Ok: " + prod.ProductionActuelle);
    }
}