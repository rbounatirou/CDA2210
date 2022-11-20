using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleSerialisation
{
    internal class CRM
    {
        public string Adresse { get; set; }

        public List<Personnel> Personnes { get; set; }

        public CRM()
        {
            this.Personnes = new List<Personnel>();
        }

        public void addPersonne(Personnel added)
        {
            this.Personnes.Add(added);
        }
    }
}
