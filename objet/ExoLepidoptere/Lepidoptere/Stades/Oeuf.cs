using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Oeuf : Stade
    {

        public static readonly int tempsDuCycleEnJours = 5;

        public Oeuf() : base() { }

        public Stade Eclore()
        {
            if (ageDansCycleEnJours >= tempsDuCycleEnJours)
                return new Chenille();
            return this;
        }

        public override Stade Evoluer()
        {
            return (this.ageDansCycleEnJours >= tempsDuCycleEnJours ?
                new Chenille() : this);
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
