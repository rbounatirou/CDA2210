using ExoBouteille;

internal class Program
{
    private static void Main(string[] args)
    {
        Bouchon bc = new Bouchon(10);
        Bouteille bt = new Bouteille(10, bc, 1.5f, 1.5f);

        Console.WriteLine(bt.Vider(1.5f) ? "la bouteille à été vidée" : "impossible de vider");
        Console.WriteLine(bt.Ouvrir() ? "La bouteille à été ouverte" : "la bouteille n'a pas pu être ouverte");
        Console.WriteLine(bt.Ouvrir() ? "La bouteille à été ouverte" : "la bouteille n'a pas pu être ouverte");
        Console.WriteLine(bt.Vider(0.7f) ? "la bouteille à été vidée" : "impossible de vider");
        Console.WriteLine(bt.Vider(0.5f) ? "la bouteille à été vidée" : "impossible de vider");
        Console.WriteLine(bt.Remplir(1.0f) ? "la bouteille à été remplie" : "impossible de remplir");
        Console.WriteLine(bt.Fermer(bc) ? "Le bouchon a été mis sur la bouteille" : "Le bouchon n'a pas pu être mis sur la bouteille");
        Console.WriteLine(bt.Remplir(0.5f) ? "la bouteille à été remplie" : "impossible de remplir");
        Console.WriteLine(bt.Ouvrir() ? "La bouteille à été ouverte" : "la bouteille n'a pas pu être ouverte");
        Console.WriteLine(bt.Remplir(0.5f) ? "la bouteille à été remplie" : "impossible de remplir");

    }
}