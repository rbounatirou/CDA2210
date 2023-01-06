using ExoCompte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueClass
{
    public class Banque
    {
        List<Compte> mesComptes = new();
        private string nom;
        private string ville;

        private void AjouteCompte(Compte _unCompte)
        {
            mesComptes.Add(_unCompte);
        }


        public void AjouteCompte(int _num, string _nom, double _solde, double _decouvertAutorise) {
            AjouteCompte(new Compte(_num, _nom, _solde, _decouvertAutorise));
        }

        public Banque(string _nom, string _ville)
        {
            nom = _nom;
            ville = _ville;
        }

        public Compte? RendCompte(int numero)
        {
            return mesComptes.Find(compte => compte.Numero == numero);
        }
        
        
    }
}
