using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Chrysalide : Stade
    {
        public static readonly int tempsDuCycleEnJours = 35;

        public Chrysalide(CriterePhysique _sesCriteres) : base(_sesCriteres) { }


    }
}
