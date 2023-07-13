using CompositeFigure.Shapes.ConcreteShapes;

namespace CompositeFigure.Visiteur
{
    public interface IVisiteurDeFigure
    {
        public abstract void VisiterEnsembleFigure(EnsembleFigure e);
        public abstract void VisiterCarre(Carre c);
    }
}