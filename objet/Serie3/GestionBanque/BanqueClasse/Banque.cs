using ExoCompte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BanqueClass
{
    public class Banque
    {
        List<Compte> mesComptes = new();
        private string nom;
        private string ville;
        
        public string Nom { get => nom; }
        public string Ville {  get => ville; }

        public int AccountNumber { get => mesComptes.Count(); }

        public Banque(string _nom, string _ville)
        {
            nom = _nom;
            ville = _ville;
        }

        private bool AjouteCompte(Compte _unCompte)
        {
            if (RendCompte(_unCompte.Numero) != null)
                return false;
            mesComptes.Add(_unCompte);
            return true;
        }


        public bool AjouteCompte(int _num, string _nom, double _solde, double _decouvertAutorise) {
            return AjouteCompte(new Compte(_num, _nom, _solde, _decouvertAutorise));
        }
        

        public Compte? RendCompte(int numero)
        {
            return mesComptes.Find(compte => compte.Numero == numero);
        }
        

        public Compte? CompteSup()
        {
            if (mesComptes.Count == 0)
                return null;
            if (mesComptes.Count == 1)
                return mesComptes[0];
            Compte compteMax = mesComptes[0];
            for (int i = 1; i < mesComptes.Count; i++)
            {
                if (mesComptes[i].Superieur(compteMax))
                    compteMax = mesComptes[i];
            } 
            return compteMax;
        }
        

       public bool Transferer(int numero_compte_expediteur,
            int numero_compte_destinateur, double montant)
        {
            Compte? c1 = RendCompte(numero_compte_expediteur);
            Compte? c2 = RendCompte(numero_compte_destinateur);
            if (c1 != null & c2 != null)
                return c1.Transferer(montant, c2);
            return false;
        }

        public override string ToString()
        {
            string str = "";
            str += String.Format("nom : {0}\nville : {1}", nom, ville);
            foreach (Compte c in mesComptes)
            {
                str += "\n" + c.ToString();
            }
            return str;
        }
    }
}
