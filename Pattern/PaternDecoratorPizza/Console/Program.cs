using PaternDecoratorPizza;

namespace Consoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PateAPizza patoune = new PateAPizza(true);
            SauceTomate sauceTomate = new SauceTomate(patoune);
            Olive olive = new Olive(sauceTomate);
            Lardon lard = new Lardon(olive);
            Console.WriteLine(lard.SePresenter());
        }
    }
}