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
            Trier();
        }

        public int[] GetValeurDes()
        {
            int[] val = new int[des.Length];
            for (int i = 0; i < des.Length; i++)
                val[i] = des[i].GetValeur();
            return val;
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
           
            if (VerifierDesExistants(_numDes))
            {
                for (int i = 0; i < _numDes.Count(); i++)
                {
                    des[ _numDes[i]].Rouler();
                    
                }

                nbLancerEffectue++;
                
            } else
            {
                throw new Exception("Impossible de lancer un dé inexistant");
            }
        }

        private bool VerifierDesExistants(List<byte> _numDes) { 
            int i = 0;
            bool correct = true;
            while(i<_numDes.Count() && correct)
            {
                correct = (_numDes[i] < des.Length);
                i++;
            }
            return correct;
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
    }
}
