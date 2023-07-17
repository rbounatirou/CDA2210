using CompositeFigure;
using CompositeFigure.Shapes.ConcreteShapes;
using ProjetFigureConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        EnsembleFigure ef = new EnsembleFigure();
        Rond rond = new Rond(new Coordonnee(10, 10), 0, 20);
        ef.AjouterFigure(rond);
        VisiteurDeFigure v = new VisiteurDeFigure();
        Console.WriteLine(ef.AccepterVisite(v));
    }
}