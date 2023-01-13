using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuClass
{
    
    public class De : IComparable<De>
    {
        private byte valeur;
        public readonly byte valeurMin = 1;
        public readonly byte valeurMax = 6;
        private Alea sonAlea;

        public byte GetValeur() => valeur;

        public Alea SonAlea { get => sonAlea;  }
        public void Rouler()
        {
            valeur = sonAlea.DonneNombreAleatoire(valeurMin, valeurMax);
        }

        public int CompareTo(De? other)
        {
            if (other.valeur < this.valeur)
            {
                return 1;
            } else if (other.valeur == this.valeur)
            {
                return 0;
            } else
            {
                return -1;
            }
        }

        public De(byte valeurMin, byte valeurMax)
        {
            this.valeurMin = valeurMin;
            this.valeurMax = valeurMax;
            sonAlea = Alea.GetInstance();
        }
    }
}
