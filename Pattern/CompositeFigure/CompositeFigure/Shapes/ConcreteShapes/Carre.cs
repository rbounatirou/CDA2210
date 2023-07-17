using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure.Shapes.ConcreteShapes
{
    public class Carre : Figure
    {
        private double tailleCoteEnMm;

        public double TailleCoteEnMM {  get => tailleCoteEnMm; private set { tailleCoteEnMm = value; } }

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

        public override object Clone()
        {
            return new Carre(this);
        }


        public override T AccepterVisite<T>(IVisiteurDeFigure<T> f)
        {
            return f.VisiterCarre(this);
        }

        public override string AccepterVisite(IVisiteurDeFigure<string> f)
        {
            return AccepterVisite<string>(f);
        }

        public override bool IsOnHitbox(double x, double y, double w, double h)
        {
            int hitbox_x = (int)(saPosition.X);
            int hitbox_y = (int)(saPosition.Y);
            int hitbox_w = (int)tailleCoteEnMm;
            int hitbox_h = (int)tailleCoteEnMm;
            Rectangle rect = new Rectangle(hitbox_x, hitbox_y, hitbox_w, hitbox_h);
            Rectangle rect2 = new Rectangle((int)x, (int)y, (int)w, (int)h);
            return rect.IntersectsWith(rect2);
        }
    }
}
