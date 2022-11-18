using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleSerialisation
{
    internal class Personnel : Personne
    {
        public double Paye { get; set; }

        public Personnel(string _nom, string _prenom, string? _birthday, double _paye) : base(_nom,_prenom,_birthday)
        {
            this.Paye = _paye;
        }

        public Personnel(string _nom, string _prenom, double _paye) : this(_nom, _prenom, null, _paye)
        {

        }
    }
}
