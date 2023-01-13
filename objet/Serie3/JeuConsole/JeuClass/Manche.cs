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
        public Manche()
        {
            nbLancerEffectue = 0;
            des = new De[3];
            for (int i = 0; i < des.Length; i++)
            {
                des[i] = new De(1, 6);
                des[i].Rouler();
            }
        }

        public void Trier()
        {
            Array.Sort(des);
            Array.Reverse(des);

        }
        
        public bool EstGagne()
        {
            return (des[0].GetValeur() == 4 &&
                des[1].GetValeur() == 2 &&
                des[2].GetValeur() == 1);
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
                    deARelancer.Add(des[i]);
                } else
                {
                    correct = false;
                }
            }
            if (correct)
            {
                for (i = 0; i < deARelancer.Count(); i++)
                {
                    deARelancer[i].Rouler();
                }
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
