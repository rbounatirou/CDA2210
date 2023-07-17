using CompositeFigure.Shapes.ConcreteShapes;
using CompositeFigure.Visiteur;
namespace CompositeFigure.Shapes
{
    public abstract class Figure : ICloneable
    {
        protected double angleEnRadian;
        protected Coordonnee? saPosition;

        public double AngleEnRadian { get => angleEnRadian; private set { angleEnRadian = value; } }
        public Coordonnee? Position { get => saPosition; private set { saPosition = value; } }


        public Figure( ) : this(new Coordonnee(0,0))
        {
        }

        public Figure(Coordonnee? position) : this(position, 0)
        {
        }

        public Figure(Coordonnee? position, double angleRadian)
        {
            this.angleEnRadian = angleEnRadian;
            this.saPosition = position ?? new Coordonnee(0, 0);
        }

        public abstract T AccepterVisite<T>(IVisiteurDeFigure<T> f);
        public abstract string AccepterVisite(IVisiteurDeFigure<string> f);

        public abstract object Clone();

        public EnsembleFigure CreerGroupe(Figure avec)
        {
           return new EnsembleFigure(new Coordonnee(0,0),0, new List<Figure>() { this, avec});
        }

        public virtual  Figure[] DissocierGroupe() { return new Figure[] { this };  }

        public virtual void RegrouperElementEnUnGroupe(params int[] idEls) { return; }

        public abstract bool IsOnHitbox(double x, double y, double w, double h);

        public virtual void DissocierElementEnPlusieurs(int idElement) { return; }
    }
}