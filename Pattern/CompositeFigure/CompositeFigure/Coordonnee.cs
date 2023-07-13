using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure
{
    public class Coordonnee
    {
        private double x;
        private double y;

        public Coordonnee(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Coordonnee(Coordonnee c) : this(c.x, c.y){ }

        public Coordonnee() : this(0, 0) { }


    }
}
