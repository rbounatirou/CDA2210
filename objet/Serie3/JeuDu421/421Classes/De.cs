using _421Classes.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuQuatreCentVingtEtUn
{
    public class De
    {
        private static Random random = new Random();
        byte[] plageDeValeurs;
        byte valeur;

        public De(byte[] _plageDeValeurs)
        {
            if (_plageDeValeurs.Length != 2)
                throw new CreateDeException("La plage de valeurs doit contenir 2 valeurs SEULEMENT!!!");
            if(_plageDeValeurs[0] < _plageDeValeurs[1])
                throw new CreateDeException(String.Format("La valeur du paramètre à l'indice 0 ({0}) doit etre strictement inférieur à l'indice 1 ({1})", _plageDeValeurs[0],
                    _plageDeValeurs[1]));
            if (_plageDeValeurs[0] == 0)
                throw new CreateDeException("La valeur à l'indice 0 doit être strictement suppérieur à 0");
            valeur = 1;
            plageDeValeurs = _plageDeValeurs;
        }

        public string AfficherInfo()
        {
            return "valeur : " + valeur;
        }

        public byte GetValeur()
        {
            return valeur;
        }

        public void Lancer()
        {
            valeur = (byte)random.Next(plageDeValeurs[0], plageDeValeurs[1] + 1);
        }
    }
}
