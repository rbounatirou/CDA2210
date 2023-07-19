using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerADroite : ICommand
    {
        private int nbPixel;
        private Personnage personnage;

        public CommandAllerADroite(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            personnage = cible;
        }

        public bool Executer()
        {
            return personnage.DeplacerADroite(nbPixel);
        }

        public bool Annuler()
        {
            return personnage.DeplacerAGauche(nbPixel);
        }

        public string GetString()
        {
            return "Droite(" + nbPixel + ")";
        }
    }
}
