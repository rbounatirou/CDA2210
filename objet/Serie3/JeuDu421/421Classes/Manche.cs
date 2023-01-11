using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuQuatreCentVingtEtUn
{
    public class Manche
    {
        private De[] des;
        private EnumEtatManche etatDeLaManche;
        private byte nombreDeLancer;
        private readonly byte nombreMaximumDeLancer;

        public Manche()
        {
            nombreDeLancer = 0;
            nombreMaximumDeLancer = 3;
            des = new De[3];
            for (int i = 0; i < des.Length; i++)
                des[i] = new De(new byte[] { 1, 6 });
            etatDeLaManche = EnumEtatManche.EnCours;
        }

        private void ControlerDes()
        {
            if (des.ToList().Find(de => de.GetValeur() == 4) != null &&
                des.ToList().Find(de => de.GetValeur() == 2) != null &&
                des.ToList().Find(de => de.GetValeur() == 1) != null)
            {
                etatDeLaManche = EnumEtatManche.Gagne;

            } else
            {
                if (nombreDeLancer >= nombreMaximumDeLancer)
                    etatDeLaManche = EnumEtatManche.Perdue;

            }
        }

        public De? GetDe(int id)
        {
            return (des.Length >= id ? des[id] : null);
        }

        public EnumEtatManche GetEtatManche()
        {
            return etatDeLaManche;
        }

        public byte GetNombreDeLancer()
        {
            return nombreDeLancer;
        }

        public bool LancerLesDes()
        {
            List<int> desALancer = new();
            for (int i = 0; i < des.Length; i++)
                desALancer.Add(i);
            return LancerLesDes(desALancer);
        }

        public bool LancerLesDes(List<int> desALancer)
        {
            if (etatDeLaManche != EnumEtatManche.EnCours ||
                nombreDeLancer >= nombreMaximumDeLancer)
                return false;
            List<De> deSelectonne = new();
            int i = 0;
            bool sortie = false;
            while (i < desALancer.Count() && !!sortie)
            {
                De tmp = GetDe(desALancer[i]);
                if (tmp == null)
                {
                    sortie = true;
                } else
                {
                    deSelectonne.Add(tmp);
                }
                i++;
            }
            if (deSelectonne.Count() != desALancer.Count())
                return false;
            foreach (De de in deSelectonne)
            {
                de.Lancer();
            }
            ControlerDes();
            return true;
        }

        public override string ToString()
        {
            string str = "etat: " + etatDeLaManche;
            for (int i = 0; i < des.Length; i++)
            {
                str += String.Format(", de{0} : {1}", i, des[i].GetValeur());
            }
            str += String.Format(", nombreDeLancer: {0}, nombreMaximumDeLancer: {1}", nombreDeLancer, nombreMaximumDeLancer);
            return str;
        }



    }
}
