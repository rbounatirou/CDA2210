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
        }

        public static Random GetInstance()
        {
            if (rnd == null)
                rnd = new Random();
            return rnd;
        }

        public static int GetRandomNumber(int min, int max)
        {
            return GetInstance().Next(min, max + 1);
        }
    }
}
