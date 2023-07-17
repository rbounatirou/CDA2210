using CompositeFigure.Visiteur;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure.Shapes.ConcreteShapes
{
    public class Rond : Shape
    {
        private double rayon;

        public double Rayon { get => rayon; private set { rayon = value; } }

        public Rond(Coordonnee? c, double angle, double rayon) : base(c, angle)
        {
            if (rayon < 0)
                throw new Exception("Impossible d'avoir un rayon négatif");
            this.rayon = rayon;
        }
        public Rond(Coordonnee? c, double angle) : this(c, angle, 0) { }

        public Rond(Coordonnee? c) : base(c) { }

        public Rond(Rond from) : this(from.saPosition, from.angleEnRadian) { }

        public override T AccepterVisite<T>(IVisiteurDeFigure<T> f)
        {
            return f.VisiterRond(this);
        }

        public override object Clone()
        {
            return new Rond(this);
        }

        public override string AccepterVisite(IVisiteurDeFigure<string> f)
        {
            return AccepterVisite<string>(f);
        }

        public override bool IsOnHitbox(double x, double y, double w, double h)
        {
            int hitbox_x = (int)(saPosition.X - rayon);
            int hitbox_y = (int)(saPosition.Y - rayon);
            int hitbox_w = (int)rayon * 2;
            int hitbox_h = (int)rayon * 2;
            Rectangle rect = new Rectangle(hitbox_x, hitbox_y, hitbox_w, hitbox_h);
            Rectangle rect2 = new Rectangle((int)x, (int)y, (int)w, (int)h);
            return rect.IntersectsWith(rect2);
        }
    }
}
