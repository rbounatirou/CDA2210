using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleCommand.Command
{
    public class CommandAllerEnHaut : ICommand
    {
        private int nbPixel;
        private Personnage personnage;

        public CommandAllerEnHaut(int pixel, Personnage cible)
        {
            nbPixel = pixel;
            personnage = cible;
        }

        public bool Executer()
        {
            return personnage.DeplacerEnHaut(nbPixel);
        }

        public bool Annuler()
        {
            return personnage.DeplacerEnBas(nbPixel);
        }

        public string GetString()
        {
            return "Haut(" + nbPixel + ")";
        }
    }
}
