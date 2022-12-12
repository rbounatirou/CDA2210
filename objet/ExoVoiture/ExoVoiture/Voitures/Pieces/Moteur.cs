using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExoVoiture.Voitures.Pieces
{
    internal class Moteur
    {
        public bool estDemarree { get; private set; }
        public uint nbChevaux { get; private set; }

        public Moteur() : this(90, false) { }

        public Moteur(uint _nbChevaux, bool _estDemaree)
        {
            this.nbChevaux = _nbChevaux;
            this.estDemarree= _estDemaree;
        }

        public Moteur(Moteur _from) : this(_from.nbChevaux, _from.estDemarree) { }
        public bool Demarrer()
        {
            if (estDemarree)
                return false;
            estDemarree = true;
            return true;
        }

        public bool Arreter()
        {
            if (!estDemarree)
                return false;
            estDemarree = false;
            
            return true;
        }

        public bool Avancer(List<Roue> rouesAAvancer)
        {
            if (!estDemarree)
                return false;
            int i = 0;
            bool peutAvancer = true;
            while (i < rouesAAvancer.Count() && peutAvancer)
            {
                peutAvancer = rouesAAvancer[i].Rouler();
                i++;
            }
            return peutAvancer;
        }
    }
}
