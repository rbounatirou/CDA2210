using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Oeuf : Stade
    {

        public static readonly int tempsDuCycleEnJours = 5;

        public Oeuf(CriterePhysique _sesCriteres) : base(_sesCriteres) { }
        public void Eclore()
        {
            Console.WriteLine("Pouf! l'oeuf à éclos");
        }

        
    }
}
