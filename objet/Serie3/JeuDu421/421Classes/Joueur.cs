using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuQuatreCentVingtEtUn
{
    public class Joueur
    {
        private string nom;
        private byte score;

        public Joueur(string nom) : this(nom, 0) { }

        public Joueur(string nom, byte score)
        {
            this.nom = nom;
            this.score = score;
        }

        public byte GetScore()
        {
            return score;
        }

        public void GagnerManche()
        {
            score += 30;
        }

        public void PerdreManche()
        {
            score -= 10;
        }
    }
}
