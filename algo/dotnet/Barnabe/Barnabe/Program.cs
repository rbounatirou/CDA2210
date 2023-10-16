namespace Barnabe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int NbMagasinRealisePArBarnabe(decimal sommeDansLePorteMonnaieDeBarnabe)
        {
            int nbMagasins = 0;
            while (sommeDansLePorteMonnaieDeBarnabe >= 2)
            {
                nbMagasins++;
                sommeDansLePorteMonnaieDeBarnabe = (sommeDansLePorteMonnaieDeBarnabe / 2) - 1;
            }
            if (sommeDansLePorteMonnaieDeBarnabe > 0)
            {
                nbMagasins++;
            }
            return nbMagasins;
        }
    }
}