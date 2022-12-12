using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Chenille : Stade
    {
        public static readonly int tempsDuCycleEnJours = 5;
   
        public int nbDeMues {  get; private set; }

        public Chenille() : base()
        {
            nbDeMues = 0;
        }

        public override Stade Evoluer()
        {
            return (ageDansCycleEnJours >= tempsDuCycleEnJours ? new Chrysalide() : this);
        }

        public void Ramper()
        {
            Console.WriteLine("Rampe");
        }

        public void Manger()
        {
            Console.WriteLine("Mange");
        }

        public void Muer()
        {
            Console.WriteLine("Mue");
            nbDeMues++;
        }

        public override bool SeDeplacer()
        {
            Ramper();
            return true;
        }

        public override bool SeReproduire(Papillon _avec)
        {
            return false;
        }
    }
}
