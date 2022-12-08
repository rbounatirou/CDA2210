using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere.Stades
{
    internal abstract class Stade
    {

        public CriterePhysique sonApparence { get; protected set; }
        public Stade(CriterePhysique _apparence)
        {
            sonApparence = new CriterePhysique(sonApparence);
        }

        public Stade()
        {
            sonApparence = new CriterePhysique();
        }
    }

}
