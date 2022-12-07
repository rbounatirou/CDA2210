namespace DanserSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Homme h = new Homme();
            Homme_Vieux p = new Homme_Vieux();
            p.Marcher();
            //
            h.Marcher();

            Homme h2 = p;
            h2.Marcher();
        }
    }
}