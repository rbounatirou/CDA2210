using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal abstract class Stade
    {

        protected uint ageDansCycleEnJours;
        public Stade(uint _ageDansCycleEnJours)
        {
            ageDansCycleEnJours= _ageDansCycleEnJours;
        }

        public Stade()
        {
            ageDansCycleEnJours = 0;
        }

        public Stade(Stade _depuis) : this(_depuis.ageDansCycleEnJours) { }
        public abstract Stade Evoluer();
        public void Vieillir(uint _tempsEnJours)
        {
            ageDansCycleEnJours += _tempsEnJours;
        }
        public abstract bool SeDeplacer();
    }

}
