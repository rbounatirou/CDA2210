using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrintheLibrary
{
    internal class Aleatoire
    {

        private static Random rnd;

        private Aleatoire()
        {
            rnd = new Random();
        }

        internal static Random GetInstance()
        {
            if (rnd == null)
            {
                new Aleatoire();
            }
            return rnd;
        }
    }
}
