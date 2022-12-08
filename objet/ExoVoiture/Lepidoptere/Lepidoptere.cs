
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
        public Stade sonStade;
        public Lepidoptere()
        {
            sonStade = new Oeuf(
                new CriterePhysique(2,new List<string> { "Vert"}, 1,0,0,false);
        }

        public void Evoluer()
        {
           
            if (sonStade.GetType() == typeof(Papillon))
            {

            } else if (sonStade.GetType() == typeof(Chrysalide))
            {

            } else if (sonStade.GetType() == typeof(Chenille))
            {
                //sonStade = new Chrysalide((Chenille)sonStade);
            } else
            {
                ((Oeuf)sonStade).Eclore();
                sonStade = new Chenille((Oeuf)sonStade);
            }

        }

    }
}
