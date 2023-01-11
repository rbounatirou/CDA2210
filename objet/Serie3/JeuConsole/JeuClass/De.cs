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
        public static readonly byte valeurMin;
        public static readonly byte valeurMax;
        private Alea sonAlea;

        public byte GetValeur() => valeur;

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

        static De()
        {
            valeurMax = 6;
            valeurMin = 1;
        }

        public De() : this(1, 6) { }

        public De(byte valeurMin, byte valeurMax)
        {
            sonAlea = Alea.GetInstance();
            this.valeurMin = valeurMin;
            this.valeurMax = valeurMax;
        }



    }
}
