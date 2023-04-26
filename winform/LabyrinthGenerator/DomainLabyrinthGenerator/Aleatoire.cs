using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLabyrinthGenerator
{
    public class Aleatoire
    {
        private static Random rnd;
        private Aleatoire()
        {
            rnd = new Random();
        }

        public static Random GetInstance()
        {
            if (rnd == null)
                new Aleatoire();
            return rnd;
        }
    }
}
