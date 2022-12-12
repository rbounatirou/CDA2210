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
        protected bool estUnMale;
        public Stade(uint _ageDansCycleEnJours, bool estUnMale)
        {
            ageDansCycleEnJours = _ageDansCycleEnJours;
            this.estUnMale = estUnMale;
        }

        public Stade()
        {
            ageDansCycleEnJours = 0;
            estUnMale = new Random().Next(0, 2) == 0;
        }

        public Stade(Stade _depuis) : this(_depuis.ageDansCycleEnJours, _depuis.estUnMale) { }
        public abstract Stade Evoluer();
        public virtual void Vieillir(uint _tempsEnJours)
        {
            ageDansCycleEnJours += _tempsEnJours;
        }
        public abstract bool SeDeplacer();


        public abstract bool SeReproduire(Papillon _avec);
    }

}
