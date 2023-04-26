using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLabyrinthGenerator
{
    public class Vecteur
    {
        int x;
        int y;
        public int X { get => x; set => x = value; }

        public int Y { get => y; set => y = value; }

        public Vecteur(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vecteur DistancePourAller(int x, int y)
        {
            return new Vecteur(x - this.x, y - this.y);
        }

        public Vecteur DistancePourAller(Vecteur v) => DistancePourAller(v.X, v.Y);

        public long ScalarProduct(Vecteur v) {
            return x * v.X + y * v.Y;
        }
    }
}
