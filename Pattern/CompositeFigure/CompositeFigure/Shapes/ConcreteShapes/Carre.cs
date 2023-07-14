using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure.Shapes.ConcreteShapes
{
    public class Carre : Figure
    {
        private double tailleCoteEnMm;

        public Carre(Coordonnee coord, double _tailleCoteMm) : base(coord)
        {            
            this.tailleCoteEnMm = _tailleCoteMm;
        }

        public Carre(Coordonnee coord, double angle, double _tailleCoteMm) : base(coord, angle)
        {
            this.tailleCoteEnMm = _tailleCoteMm;
        }
        public Carre(Carre from)
        {
            this.saPosition = new Coordonnee(from.saPosition);
            this.angleEnRadian = from.angleEnRadian;
            this.tailleCoteEnMm = from.tailleCoteEnMm;
        }

        public override Figure Clone()
        {
            return new Carre(this);
        }


        public override void AccepterVisite(IVisiteurDeFigure<string> f)
        {
            f.VisiterCarre(this);
        }
    }
}
