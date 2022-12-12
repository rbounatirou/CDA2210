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

        public Chrysalide() : base() { }

        public override Stade Evoluer()
        {
            return (ageDansCycleEnJours >= tempsDuCycleEnJours ? new Papillon() : this);
        }

        public override bool SeDeplacer()
        {
            return false;
        }

        public override bool SeReproduire(Papillon _avec)
        {
            return false;
        }
    }
}
