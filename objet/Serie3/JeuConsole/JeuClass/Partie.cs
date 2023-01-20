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


        public ushort Score { get => score;  }
        public Manche MancheCourrante { get => mancheCourrante;  }

        public byte NombreMancheEffectuees { get => nombreManchesEffectuees; }

        public Partie(byte nombrMancheSouhaitees)
        {
            this.nombreManchesSouhaitees = nombrMancheSouhaitees;
            nombreManchesEffectuees = 1;
            mancheCourrante = new Manche();
            score = (ushort)(nombreManchesSouhaitees * 10);
        }

        public Partie() : this(1) { }

        public bool PeutCreerUneNouvelleManche()
        {
            return ((EstCeQueLaMancheCourranteEstGagne() ||
                !EstCeQueLaMancheCourranteAEncoreUnLancer()) &&
                nombreManchesEffectuees < nombreManchesSouhaitees);
        }
        public void CreerUneNouvelleManche()
        {
            if (PeutCreerUneNouvelleManche())
            {
                mancheCourrante = new Manche();
                nombreManchesEffectuees++;
            }
        }

        public bool EstCeQueLaMancheCourranteAEncoreUnLancer()
        {
            return mancheCourrante.AEncoreUnLancer();
        }

        public bool EstCeQueLaMancheCourranteEstGagne()
        {


            return mancheCourrante.EstGagne();
         
        }

        public void AjouterPoint()
        {
            if (mancheCourrante.EstGagne())
                score += 30;
        }

        public void RetirePoint()
        {
            if (!mancheCourrante.EstGagne() && !mancheCourrante.AEncoreUnLancer())
                score -= 10;
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





        public bool AEncoreUneMancheAJouer()
        {
            return nombreManchesEffectuees < nombreManchesSouhaitees;
        }
 
    }
}
