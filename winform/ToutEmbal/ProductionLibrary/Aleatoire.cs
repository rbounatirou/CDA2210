using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLibrary
{
    internal class Aleatoire
    {
        private static Random rnd;
        private Aleatoire()
        {
            rnd = new Random();
        }

        private int GetAlea(int min, int max)
        {
            if (rnd == null)
                new Aleatoire();
            return rnd.Next(min, max + 1);
        }
    }
}
