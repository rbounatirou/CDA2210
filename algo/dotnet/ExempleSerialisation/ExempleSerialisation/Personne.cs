using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExempleSerialisation
{
    internal class Personne
    {
        [JsonInclude]
        public string Nom { get;  private set; }

        [JsonInclude]
        public string Prenom { get;  private set; }

        [JsonInclude]
        public string? Birthday{get;  private set;}

        [JsonConstructor]
        public Personne(string Nom, string Prenom, string? Birthday)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Birthday = Birthday;
        }

        public Personne(string _nom, string _prenom) : this(_nom, _prenom, null) { }

        


    }
}
