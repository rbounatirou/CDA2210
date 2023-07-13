using CompositeFigure.Shapes.ConcreteShapes;

namespace VisiteurFigure
{
    public interface IVisiteurDeFigure
    {
        public abstract void VisiterEnsembleFigure(EnsembleFigure e);
        public abstract void VisiterCarre(Carre c);
    }
}