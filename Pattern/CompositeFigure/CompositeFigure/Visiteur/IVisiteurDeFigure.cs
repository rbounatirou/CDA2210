using CompositeFigure.Shapes.ConcreteShapes;

namespace CompositeFigure.Visiteur
{
    public interface IVisiteurDeFigure<T>
    {
        public abstract T VisiterEnsembleFigure(EnsembleFigure e);
        public abstract T VisiterCarre(Carre c);

        public abstract T VisiterRond(Rond r);
    }
}