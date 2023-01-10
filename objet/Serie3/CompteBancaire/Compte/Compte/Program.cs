
namespace ExoCompte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exemple3();
        }

        static void exemple1()
        {
            Compte b = new Compte(545454, "Laurent", 2000, -500);

            b.Crediter(100);
            Console.WriteLine(b);
            bool ok = b.Debiter(1000000);
            Console.WriteLine("Débit " + (ok ? "" : "pas ") + "réussi");
        }

        static void exemple2()
        {
            
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            c1.Transferer(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }

        static void exemple3()
        {
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Compte c2 = new Compte(45657, "titi", 2000, -1000);
            Console.WriteLine(c1.Superieur(c2) ? "superieur" : "inferieur");
        }
    }
}