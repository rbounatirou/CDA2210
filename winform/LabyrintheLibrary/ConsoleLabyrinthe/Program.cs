using LabyrintheLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace ConsoleLabyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labyrinthe lb = (File.Exists("obj.bin") ? Labyrinthe.Deserialize("obj.bin") : new Labyrinthe(21,21));
            lb.Generer();
            lb.Serialize("obj.bin");
            Djikstra djikstra = new Djikstra(lb, 0, 1, lb.W-1, lb.H - 2);
            //List<int> lbDir = lb.GetDirectionsPossibles(0, 1);
            Console.WriteLine("Termine");
           
        }
    }
}