
using Lepidoptere.Stades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Lepidoptere
    {
        public Stade sonStade { get; private set; }

        private uint ageEnJours;


        public Lepidoptere()
        {
            sonStade = new Oeuf();
            ageEnJours = 0;
        }



        public void Vieillir(uint _tempsEnJours)
        {
            if (_tempsEnJours > 0)
            {
                ageEnJours += _tempsEnJours;
                sonStade.Vieillir(_tempsEnJours);
                sonStade = sonStade.Evoluer();
            }
        }



        public bool SeReproduire(Papillon _avec)
        {
            return sonStade.SeReproduire(_avec);
        }

    }
}
