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

        public Oeuf() : base(0) { }

        public Stade Eclore()
        {
            if (ageDansCycleEnJours >= tempsDuCycleEnJours)
                return new Chenille();
            return null;
        }

        public override Stade Evoluer()
        {
            Stade result = Eclore();
            return (result != null ? result : this);
        }

        public override bool SeDeplacer()
        {
            return false;
        }

    }
}
