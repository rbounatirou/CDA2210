using fraction;

internal class Program
{
    private static void Main(string[] args)
    {
        Fraction f = new Fraction(11, 7);
        Fraction f1 = new Fraction(22, 14);
        Console.WriteLine(f - f1);

    }
}