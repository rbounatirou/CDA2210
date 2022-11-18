using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleSerialisation
{
    internal class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string? Birthday{get; set;}

        public Personne(string _nom, string _prenom, string? _birthday= null)
        {
            this.Nom = _nom;
            this.Prenom = _prenom;
            this.Birthday = _birthday;
        }

    }
}
