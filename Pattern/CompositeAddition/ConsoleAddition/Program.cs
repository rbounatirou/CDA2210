using CompositeAddition.Binaires.Operations;
using CompositeAddition;

namespace ConsoleAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Addition a = new Addition(new Nombre(33), new Nombre(11));
            Addition b = new Addition(new Nombre(33), a);
            double n = b.Calculer();
            
        }
    }
}