
using Lepidoptere.Stades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class Lepidoptere
    {
        public Stade sonStade {  get; private set; }
        private bool estUnMale;
        private uint ageEnJours;
        private bool estFeconde;
        private uint tempsGestationActuel;
        public Lepidoptere()
        {
            sonStade = new Oeuf();
            estUnMale = (new Random().Next(0, 2)) == 0;
            ageEnJours = 0;
            estFeconde = false;
            tempsGestationActuel = 0;
        }

        public Lepidoptere(Stade _sonStade,
            bool _estUnMale, uint _ageEnJours)
        {
            sonStade = _sonStade;
            estUnMale= _estUnMale;
            ageEnJours= _ageEnJours;
        }

        public void Vieillir(uint _tempsEnJours)
        {
            ageEnJours += _tempsEnJours;
            if (estFeconde)
                tempsGestationActuel += _tempsEnJours;
            sonStade.Vieillir(_tempsEnJours);
            sonStade = sonStade.Evoluer();
        }

        public List<Lepidoptere> Pondre()
        {

            List<Lepidoptere> retour = new List<Lepidoptere>();
            if (estFeconde && tempsGestationActuel >= Papillon.TEMPS_GESTATION)
            {
                int nb = new Random().Next(0, 300);
                for (int i = 0; i < nb; i++)
                {
                    retour.Add(new Lepidoptere());
                }
                estFeconde = false;
            }            
            return retour;
        }

        public bool SeReproduire(Lepidoptere _avec)
        {
            if (this.sonStade is Papillon &&
                _avec is Papillon)
            {
                if (estUnMale)
                    Feconder(_avec);
                else
                    EtreFecondee(_avec);
            }
            return false;
        }

        private bool Feconder(Lepidoptere _partenaire)
        {
            return _partenaire.EtreFecondee(this);
        }

        private bool EtreFecondee(Lepidoptere _partenaire)
        {
            estFeconde = (_partenaire.estUnMale && !this.estUnMale);
            return estFeconde;
        }

    }
}
