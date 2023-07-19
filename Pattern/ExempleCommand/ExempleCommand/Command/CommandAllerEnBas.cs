using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerEnBas : ICommand
    {
        private int nbPixel;
        private Personnage personnage;

        public CommandAllerEnBas(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            personnage = cible;
        }

        public bool Executer()
        {
            return personnage.DeplacerEnBas(nbPixel);
        }

        public bool Annuler()
        {
            return personnage.DeplacerEnHaut(nbPixel);
        }

        public string GetString()
        {
            return "Bas(" + nbPixel + ")";
        }
    }
}
