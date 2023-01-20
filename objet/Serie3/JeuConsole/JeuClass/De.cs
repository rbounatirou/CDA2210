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


        public byte GetValeur() => valeur;

        public void Rouler()
        {
     
            valeur = Alea.GetInstance().DonneNombreAleatoire(valeurMin, valeurMax);
            //valeur=  (byte)rnd.Next(valeurMin, valeurMax);
        }

        public int CompareTo(De? other)
        {
            if (other == null)
                throw new ArgumentNullException("Probleme argument null");
            return (this.valeur.CompareTo(other.valeur));
        }

        public De(byte valeurMin, byte valeurMax)
        {
            this.valeurMin = valeurMin;
            this.valeurMax = valeurMax;
            Rouler();
        }

        public static bool operator <(De left, De right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(De left, De right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(De left, De right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(De left, De right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
