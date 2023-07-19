using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerAGauche : ICommand
    {
        private int nbPixel;
        private Personnage personnage;
        
        public CommandAllerAGauche(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            personnage = cible;
        }

        public bool Executer()
        {
            return personnage.DeplacerAGauche(nbPixel);
        }

        public bool Annuler()
        {
            return personnage.DeplacerADroite(nbPixel);
        }

        public string GetString()
        {
            return "Gauche(" + nbPixel + ")";
        }
    }
}
