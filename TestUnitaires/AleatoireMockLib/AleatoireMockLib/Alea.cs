using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleatoireMockLib
{
    public class Alea : Random
    {
        private static Alea alea;

        private Alea()
        {
            alea = new Alea();
        }

        public static Alea GetInsance()
        {
            if (alea == null)
                new Alea();
            return alea;
        }

        public static int GetNumber(int min, int max) => GetInsance().Next(min, max+1);
    }
}
