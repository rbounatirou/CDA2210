using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanserSalon
{
    internal class Femme : Personne
    {

        public void Suivre()
        {
            Console.WriteLine("Suivre");
        }

        public override void DanserSalon()
        {
            Suivre();
            Console.WriteLine("Danse le salon");
        }
    }
}
