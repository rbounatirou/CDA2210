
using BanqueClass;
using ExoCompte;
using System.Reflection;

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
            TestReflexion(new Compte());
        }        


        public static void TestReflexion(Object o)
        {
           
            FieldInfo[] inf = o.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //var en3 = o.GetType().GetProperty("numeroCompte", BindingFlags.NonPublic | BindingFlag.Instance);
            foreach (FieldInfo pi in inf)
            {
                
                Console.WriteLine(pi.Name + ": " + pi.GetValue(o));
            }
            FieldInfo? fl = o.GetType().GetField("numeroCompte", BindingFlags.NonPublic) ;
            fl.SetValue(o, (Int32)12);
        }
    }
}
