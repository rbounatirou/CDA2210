using ExpressionCompositeScrachNico;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition(new Addition(new Addition(new Nombre(3), new Nombre(2)),
                new Soustraction(new Nombre(4), new Nombre(8))), new Nombre(3));
            Console.WriteLine(a.GetValue());
        }
    }
}