using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuClass
{
    public class Partie
    {
        private Manche mancheCourrante;
        private int nombreManchesSouhaitees;
        private int nombreManchesEffectuees;
        private ushort score;

        public Partie()
        {
            
        }

        public Partie(int nombrMancheSouhaitees)
        {
            this.nombreManchesSouhaitees = nombreManchesSouhaitees;
        }
 
    }
}
