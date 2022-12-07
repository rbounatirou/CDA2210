using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanserSalon
{
    internal class Homme : Personne
    {
        public void Mener()
        {
            Console.WriteLine("Mene");
        }

        public override void DanserSalon()
        {
            Mener();
            Console.WriteLine("Danser salon");
        }
    }
}
