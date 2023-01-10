using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point
{
    internal class Point
    {
        private double x;

        private double y;

        public double X { get => x;  }

        public double Y { get => y;  }

        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public Point() : this(0, 0) { }


        private void Move(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        private void Permuter()
        {
            double a = x;
            x = y;
            y = a;
        }

        private Point SymetricX()
        {
            return new Point(-x, y);
        }

        private Point SymetricY()
        {
            return new Point(x, -y);
        }

        private Point SymetricOrigin()
        {
            return this.SymetricX().SymetricY();
        }

        public override string ToString()
        {
            return String.Format("x : {0}, y: {1}", x, y);
        }
    }
}
