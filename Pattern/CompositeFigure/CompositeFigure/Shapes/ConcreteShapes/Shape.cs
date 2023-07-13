using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeFigure.Shapes.ConcreteShapes
{
    public abstract class Shape : Figure
    {
        public Shape(Coordonnee? c, double angle) : base(c, angle)
        {
            if (c == null)
                throw new Exception("Impossible to create a shape with a null position");
            
        }

        public Shape(Coordonnee? c) : this(c, 0) { }
     }
}
