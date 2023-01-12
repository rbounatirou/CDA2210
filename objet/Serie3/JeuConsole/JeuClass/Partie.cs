using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuClass
{
    public class Partie
    {
        private Manche mancheCourrante;
        private byte nombreManchesSouhaitees;
        private byte nombreManchesEffectuees;
        private ushort score;

        public Partie()
        {
            nombreManchesSouhaitees = 1;
            nombreManchesEffectuees = 0;
            mancheCourrante = new Manche();
        }

        public void CreerUneNouvelleManche()
        {
            if (!EstCeQueLaMancheCourranteAEncoreUnLancer() &&
                nombreManchesEffectuees < nombreManchesSouhaitees)
                mancheCourrante = new Manche();
        }

        private bool EstCeQueLaMancheCourranteAEncoreUnLancer()
        {
            return mancheCourrante.AEncoreUnLancer();
        }

        private bool EstCeQueLaMancheCourranteEstGagne()
        {
           if (mancheCourrante.EstGagne())
            {
                score += 30;
                return true;
            }
            score -= 10;
            return false;
         
        }

        public ushort GetScore() => score;

        public void RelancerDes()
        {
            mancheCourrante.Relancer();
        }

        public void RelancerDe(byte de)
        {
            mancheCourrante.Relancer(de);
        }


        public void RelancerDes(byte[] des)
        {
            mancheCourrante.Relancer(des);
        }


        public Partie(byte nombrMancheSouhaitees)
        {
            this.nombreManchesSouhaitees = nombrMancheSouhaitees;
        }

        public bool AEncoreUneMancheAJouer()
        {
            return nombreManchesEffectuees < nombreManchesSouhaitees;
        }
 
    }
}
