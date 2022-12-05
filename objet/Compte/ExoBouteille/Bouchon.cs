using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBouteille
{
    internal class Bouchon
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

        /// <summary>
        /// Instancie l'objet avec les paramètre souhaités
        /// </summary>
        /// <param name="diametreMm">Désigne le diametre en MM</param>
        public Bouchon(float diametreMm)
        {
            this.diametreMm = diametreMm;
        }
    }
}
