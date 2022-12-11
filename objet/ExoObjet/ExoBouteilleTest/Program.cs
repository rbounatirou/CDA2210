using ExoBouteille;

namespace ExoBouteilleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BouteilleTest bt = new BouteilleTest();
            bool rt = (new Bouchon(10.0f) == new Bouchon(10.0f));
            bt.TestOuverture();
            bt.TestFermeture();
            bt.TestViderTout();
            bt.TestRemplirTout();
            bt.TestVider();
            bt.TestRemplir();
            Console.WriteLine("Ok");
        
        }
    }
}