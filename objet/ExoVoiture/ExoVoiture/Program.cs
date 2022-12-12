using ExoVoiture.Voitures;

namespace ExoVoiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture();
            Voiture voiture2 = new Voiture(voiture1);
        }
    }
}