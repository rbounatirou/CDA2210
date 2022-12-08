using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal class Chenille : Stade
    {
        public static readonly int tempsDuCycleEnJours = 5;
   
        public int nbDeMues {  get; private set; }

        public Chenille(CriterePhysique _sesCriteres) : base(_sesCriteres) { }


        public Chenille(Oeuf _depuis) 
        {
            this.sonApparence = new CriterePhysique(10,
                new List<string> { "Vert", "Blanc" },
                5,
                _depuis.sonApparence.ageEnJours,
                0,
                _depuis.sonApparence.estUnMale);
        }
        public void Ramper()
        {
            Console.WriteLine("Rampe");
        }

        public void Manger()
        {
            Console.WriteLine("Mange");
        }

        public void Muer()
        {
            Console.WriteLine("Mue");
            nbDeMues++;
        }

        


    }
}
