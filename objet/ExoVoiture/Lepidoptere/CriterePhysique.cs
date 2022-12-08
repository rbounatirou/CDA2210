using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lepidoptere
{
    internal class CriterePhysique
    {

        public float poidsEnGrammes { get; private set; }
        public List<string> couleurs { get; private set; }
        public float tailleEnCm { get; private set; }

        public uint ageEnJours {  get; private set; }
        public uint ageDansCycleEnJours {  get; private set; }

        public bool estUnMale { get; private set; }

        public CriterePhysique(float _poidsEnGrammes,
            List<string> _couleurs,
            float _tailleEnCm,
            uint _ageEnJours,
            uint _ageDansCycleEnJours,
            bool _estUnMale)
        {
            poidsEnGrammes= _poidsEnGrammes;
            couleurs= _couleurs;
            tailleEnCm= _tailleEnCm;
            ageEnJours = _ageEnJours;
            ageDansCycleEnJours = _ageDansCycleEnJours;
            estUnMale = _estUnMale;
        }

        public CriterePhysique(CriterePhysique _aCopie) : this(_aCopie.poidsEnGrammes, _aCopie.couleurs, _aCopie.tailleEnCm,  _aCopie.ageEnJours, _aCopie.ageDansCycleEnJours, _aCopie.estUnMale) { }

        public CriterePhysique() : this(0,new List<string>(),0,0,0,false) { }
    
       
    }
}
