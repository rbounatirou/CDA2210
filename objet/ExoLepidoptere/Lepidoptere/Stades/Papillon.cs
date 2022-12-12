using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Papillon : Stade
    {
        public static readonly int TEMPS_CYCLE = 270;

        private static readonly uint TEMPS_GESTATION = 0;

        private bool estFeconde;

        private uint tempsGestationActuel;
        public Papillon() : base() {
            estFeconde = false;
            tempsGestationActuel = 0;
        }

        public override void Vieillir(uint _tempsEnJours)
        {
            base.Vieillir(_tempsEnJours);
            if (!estUnMale && estFeconde)
                tempsGestationActuel += _tempsEnJours;

        }

        public override bool SeDeplacer()
        {
            int rnd = new Random().Next(0, 2);
            if (rnd == 0)
                Voler();
            else
                Marcher();
            return true;
        }

        public override Stade Evoluer()
        {
            return this;
        }

        public void Voler()
        {
            Console.WriteLine("Le papillon vole");
        }

        public void Aspirer()
        {
            Console.WriteLine("Le papillon aspire");
        }

        public void Marcher()
        {
            Console.WriteLine("Le papillon marche");
        }

        private bool EtreFecondee(Papillon _partenaire)
        {
            estFeconde = (!this.estUnMale && _partenaire.estUnMale);
            return estFeconde;
        }

        private bool Feconder(Papillon _partenaire)
        {
            return _partenaire.EtreFecondee(this);
        }

        public override bool SeReproduire(Papillon _avec)
        {
            return (this.estUnMale ? Feconder(_avec) : EtreFecondee(_avec));
        }

        private List<Lepidoptere> Pondre()
        {
            List<Lepidoptere> rt = new List<Lepidoptere>();
            if (estFeconde &&
                !estUnMale &&
                tempsGestationActuel >= TEMPS_GESTATION)
            {
                int nbOeuf = new Random().Next(50, 501);
                for (int i = 0; i < nbOeuf; i++)
                {
                    rt.Add(new Lepidoptere());
                }
            }
            return rt;
        }
    }
}
