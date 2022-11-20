using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExempleSerialisation
{
    internal class Personnel : Personne
    {
        [JsonInclude]
        public double? Paye { get; private set; }

        [JsonConstructor]
        public Personnel(double? Paye, string Nom, string Prenom, string? Birthday) : base(Nom,Prenom,Birthday)
        {
            this.Paye = Paye;
        }

        public Personnel(string _nom, string _prenom,  string? _birthday , double? _paye) : this(_paye, _nom, _prenom, _birthday)
        {

        }
        public Personnel(string _nom, string _prenom, double? _paye) : this(_nom, _prenom, null, _paye)
        {

        }

        public Personnel(string _nom, string _prenom) : this( _nom, _prenom, null, null)
        {

        }
}
}
