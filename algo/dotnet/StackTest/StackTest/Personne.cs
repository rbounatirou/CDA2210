using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    internal class Personne : IComparable<Personne>
    {
        
        public string Nom { get; set; }

        public Personne(string _nom)
        {
            this.Nom = _nom;
        }

        public int CompareTo(Personne other)
        {
            return this.Nom.Length - other.Nom.Length;   
        }
    }
}
