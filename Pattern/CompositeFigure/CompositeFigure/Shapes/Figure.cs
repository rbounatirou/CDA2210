using CompositeFigure.Visiteur;
namespace CompositeFigure.Shapes
{
    public abstract class Figure
    {
        protected double angleEnRadian;
        protected Coordonnee? saPosition;

        public Figure( )
        {
            this.angleEnRadian = 0;
            this.saPosition = null;
        }

        public Figure(Coordonnee? position)
        {
            this.angleEnRadian = 0;
            this.saPosition = position;
        }

        public Figure(Coordonnee? position, double angleRadian)
        {
            this.angleEnRadian = angleEnRadian;
            this.saPosition = position;
        }

        public abstract void AccepterVisite(IVisiteurDeFigure<string> f);

        public abstract Figure Clone();

        
    }
}