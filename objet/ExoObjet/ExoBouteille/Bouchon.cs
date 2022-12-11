using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBouteille
{
    public class Bouchon
    {

        /// <summary>
        /// désigne le diametre du bouchon en milimètre
        /// </summary>
        public float diametreMm { get; private set; }


        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Bouchon() : this(20) { }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="_from">designe l'instance à copier</param>
        public Bouchon(Bouchon _from) : this(_from.diametreMm) { }

        /*public static bool operator==(Bouchon? _from, Bouchon? _this)
        {
            float? float1 = (_from is null ? null : _from.diametreMm);
            float? float2 = (_this is null ? null : _this.diametreMm);

            return (bool)(float1 == float2);
        }

        public static bool operator!=(Bouchon _from, Bouchon _this)
        {
            
            return !(_from == _this);
        }*/
        /// <summary>
        /// Instancie l'objet avec les paramètre souhaités
        /// </summary>
        /// <param name="diametreMm">Désigne le diametre en MM</param>
        public Bouchon(float _diametreMm)
        {
            this.diametreMm = _diametreMm;
        }
    }
}
