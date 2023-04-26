using LabyrintheLibrary;

namespace ConsoleLabyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe lb = new Labyrinthe(9,9);
            lb.Generer();
            Console.WriteLine(lb);
        }
    }
}