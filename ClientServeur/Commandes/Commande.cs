using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communications
{
    [Serializable]
    public class Commande
    {
        private EnumTypeCommande type;
       
        private Dictionary<string, string> parametres;
        public EnumTypeCommande Type { get=>type; }
        public  Dictionary<string, string> Parametres {  get => parametres; }

        public Commande(EnumTypeCommande _type)
        {
            type = _type;
            parametres = new Dictionary<string, string>();
            
        }

        public Commande(EnumTypeCommande _type, Dictionary<string, string> _pars)
        {
            type = _type;
            if (_pars != null)
            {
                for (int i = 0; i < _pars.Count; i++)
                {
                    parametres.Add(_pars.Keys.ElementAt(i), _pars.Values.ElementAt(i));
                }
            }
        }

        public void AddCommande(string k, string v)
        {
            parametres.Add(k, v);
        }

        
    }
}
