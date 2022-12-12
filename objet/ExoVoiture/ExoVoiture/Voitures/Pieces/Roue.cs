using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVoiture.Voitures.Pieces
{
    internal class Roue
    {
        public bool roule { get; private set; }
        public float diametreEnCm {  get; private set; }

        public Roue() : this(20.0f, false) { }

        public Roue(float _diametreEnCm, bool _roule)
        {
            this.diametreEnCm = _diametreEnCm;
        }


        public Roue(Roue _from) : this(_from.diametreEnCm, _from.roule) { }
        public bool Rouler()
        {
            if (!roule)
                roule = true;
            return true;
        }

        public bool Arreter()
        {
            if (!roule)
                return false;
            roule = false;
            return true;
        }
    }
}
