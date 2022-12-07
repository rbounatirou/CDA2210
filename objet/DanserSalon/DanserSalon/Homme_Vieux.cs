using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanserSalon
{
    internal class Homme_Vieux : Homme
    {
        private string nom;
        public override void Marcher()
        {
            base.Marcher();

            Console.WriteLine("Pause");
        }
    }
}
