
using BanqueClass;
using ExoCompte;

namespace GestionBanque
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Banque bc = new Banque("James Largent", "Lingot sur loire");
            bc.AjouteCompte(123, "Bounatirou", 5000.0D, -500D);
            bc.AjouteCompte(4523, "Rebecca", 5000.0D, -500D);

            Console.WriteLine(bc);
        }        

    }
}
