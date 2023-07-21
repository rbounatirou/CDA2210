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
        private Personnage sonReveiver;
        
        public CommandAllerAGauche(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            sonReveiver = cible;
        }

        public bool Executer()
        {
            return sonReveiver.DeplacerAGauche(nbPixel);
        }

        public bool Annuler()
        {
            return sonReveiver.DeplacerADroite(nbPixel);
        }

        public string GetString()
        {
            return "Gauche(" + nbPixel + ")";
        }
    }
}
