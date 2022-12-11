using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Papillon : Stade
    {
        public static readonly int TEMPS_CYCLE = 270;

        public static readonly uint TEMPS_GESTATION = 0;
        public Papillon() : base() { }

        public override bool SeDeplacer()
        {
            int rnd = new Random().Next(0, 2);
            if (rnd == 0)
                Voler();
            else
                Marcher();
            return true;
        }

        public override Stade Evoluer()
        {
            return this;
        }

        public void Voler()
        {
            Console.WriteLine("Le papillon vole");
        }

        public void Aspirer()
        {
            Console.WriteLine("Le papillon aspire");
        }

        public void Marcher()
        {
            Console.WriteLine("Le papillon marche");
        }

    }
}
