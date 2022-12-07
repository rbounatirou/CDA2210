using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanserSalon
{
    abstract class Personne
    {
        protected uint age;

        public void DanserDisco()
        {
            Console.WriteLine("Danser le disco");
        }

        public abstract void DanserSalon();

        public virtual void Marcher()
        {
            Console.WriteLine("Marche");
        }
    }
}
