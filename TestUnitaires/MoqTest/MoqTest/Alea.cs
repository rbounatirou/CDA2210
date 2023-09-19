using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTest
{
    public class Alea
    {
        private static Random rnd;
        public Alea()
        {
            rnd = new Random();
        }

        public static Random GetInstance()
        {
            if (rnd != null)
                new Alea();
            return rnd;
        }
    }
}
