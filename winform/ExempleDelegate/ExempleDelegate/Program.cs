using Productions;

internal class Program
{
    private static void Main(string[] args)
    {
        Production p = new Production();
        
        p.FinishedEvent += new Production.Event_ProductionTermine(Program.OnFinish);
        p.QuantityChangedEvent += new Production.Event_QuantityChanged(Program.OnQuantityChanged);
        p.Produire();
    }

    private static void OnFinish(Production p)
    {
        Console.WriteLine("Production termine");
    }

    private static void OnQuantityChanged(Production p)
    {
        Console.WriteLine("Production actuelle changé -> " + p.NbUniteProduite);
    }
}