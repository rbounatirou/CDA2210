// See https://aka.ms/new-console-template for more information
using ProductionLibrary;
using static ProductionLibrary.Production;

public class Program
{
   

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Production prod = new Production(EnumVitesseProduction.CAISSE_C);
        Production prod2 = new Production(EnumVitesseProduction.CAISSE_A);
       // prod.ProductionActuelleChanged += new Production.Event_OnProductionChanged(Program.MethodDelegate);
        //prod2.ProductionActuelleChanged += new Production.Event_OnProductionChanged(Program.MethodDelegate);
        prod.ProductionFinished += new Production.Event_OnProductionFinished(Program.MethodDelegateFinish);
        prod.ProductionStopped += new Production.Event_OnProductionStopped(Program.MethodDelegateStop);
        prod.ProductionReloaded += new Production.Event_OnProductionReloaded(Program.MethodDelegateReloaded);
        prod.Demarrer();
        prod2.Demarrer();



        //Thread.Sleep(5000);
        //prod.Arreter();
    }

    private static void MethodDelegate(Production prod)
    {
        Console.WriteLine("Production: " + prod.VitesseProduction + " " + prod.NbProductionActuelleNonViableDerniereHeure);
    }

    private static void MethodDelegateFinish(Production prod)
    {
        Console.WriteLine("Production finie " + prod.VitesseProduction);
    }

    private static void MethodDelegateStop(Production prod)
    {
        Console.WriteLine("Production ARRET " + prod.VitesseProduction);
        //prod.Continuer();
    }
    
    private static void MethodDelegateReloaded(Production prod)
    {
        Console.WriteLine("Production RELOADED " + prod.VitesseProduction);
        Thread.Sleep(1000);
        prod.Continuer();
    }
}