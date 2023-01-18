using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuClass
{
    public class Manche
    {
        private const byte nbLancerMax = 3;
        private byte nbLancerEffectue;
        private De[] des;

        public De[] Des { get => des; }

        public Manche()
        {
            nbLancerEffectue = 0;
            des = new De[3];
            for (int i = 0; i < des.Length; i++)
            {
                des[i] = new De(1, 6);
                des[i].Rouler();
            }
            Trier();
        }

        public void SetDes(De de1, De de2, De de3)
        {
            des[0] = de1;
            des[1] = de2;
            des[2] = de3;
        }

        public virtual byte GetValeur(int d)
        {
            return des[d].GetValeur();
        }
        public void Trier()
        {
            Array.Sort(des);
            Array.Reverse(des);
        }
        
        public bool EstGagne()
        {
            return (GetValeur(0) == 4 &&
                GetValeur(1) == 2 &&
                GetValeur(2) == 1);
        }


        public bool AEncoreUnLancer()
        {
            return nbLancerEffectue < nbLancerMax;
        }


        public void Relancer()
        {
            List<byte> list = new();
            for (byte i = 0; i < des.Length; i++)
                list.Add(i);
            Relancer(list);
        }     

        private void Relancer(List<byte> _numDes)
        {
            List<De> deARelancer = new();
            int i = 0;
            bool correct = true;
            while(i < _numDes.Count() && correct)
            {
                if (_numDes[i] < des.Length)
                {
                    deARelancer.Add(des[_numDes[i]]);
                } else
                {
                    correct = false;
                }
                i++;
            }
            if (correct)
            {
                for (i = 0; i < deARelancer.Count(); i++)
                {
                    deARelancer[i].Rouler();
                    
                }
                nbLancerEffectue++;
                
            } else
            {
                throw new Exception("Impossible de lancer un dé inexistant");
            }
        }

        public void Relancer(byte de)
        {
            Relancer(new List<byte>() { de });
        }

        public void Relancer(byte[] des)
        {
            Relancer(des.ToList());
        }

        public override string ToString()
        {
            string str = String.Format("nbLancerMax : {0}, nbLancerEffectue: {1}");
            for (int i = 0; i < des.Length; i++)
                str += String.Format(", de n°{0} : {1}", i, des[i]);
            return str;
        }

        public void Passer()
        {
            this.nbLancerEffectue = nbLancerMax;
        }
    }
}
