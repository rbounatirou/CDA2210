using AdditionneurBibli;

internal class Program
{
    private static void Main(string[] args)
    {
        OperationHistory resultat = new OperationHistory("12+4=16+4=20");
        Console.WriteLine(resultat.GetResults());
    }
}