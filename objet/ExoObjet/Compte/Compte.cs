using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExoCompte
{
    internal class Compte
    {
        /// <summary>
        /// désigne le numéro du compte
        /// </summary>
        private int numeroCompte;

        /// <summary>
        /// désigne le nom du titulaire du compte
        /// </summary>
        private string nomTitulaire;

        /// <summary>
        /// désigne le solde sur le compte
        /// </summary>
        private double solde;

        /// <summary>
        /// désigne le découvert autorisé du compte
        /// </summary>
        private double decouvertAutorise;


        /// <summary>
        /// Constructeur par défaut fait appel à la surcharge avec les paramètre (0,"Anonyme",0,0)
        /// </summary>
        /// <remarks>
        /// <see cref="Compte(int,string,double,double)"/>
        /// </remarks>
        public Compte() : this(0, "Anonyme", 0, 0) { }

        /// <summary>
        /// Constructeur qui construit l'instance via une autre instance
        /// </summary>
        /// <param name="_depuis">Compte depuis lequel sera crée l'instance</param>
        /// <remarks>
        /// <see cref="Compte(int,string,double,double)"/>
        /// </remarks>
        public Compte(Compte _depuis) : this(_depuis.numeroCompte,_depuis.nomTitulaire, _depuis.solde, _depuis.decouvertAutorise){  }

        /// <summary>
        /// Constructeur principal
        /// </summary>
        /// <param name="_numeroCompte">désigne le numéro de compte à associer à l'instance</param>
        /// <param name="_nomTitulaire">désigne le nom du titulaire du compte à associer à l'instance</param>
        /// <param name="_solde">désigne le solde du compte à associer à l'instance</param>
        /// <param name="_decouvertAutorise">désigne le découvert autorisé à associer à l'instance</param>
        public Compte(int _numeroCompte, string _nomTitulaire, double _solde, double _decouvertAutorise)
        {
            this.numeroCompte = _numeroCompte;
            this.nomTitulaire = _nomTitulaire;
            this.solde = _solde;
            if (_decouvertAutorise < 0)
               this.decouvertAutorise= _decouvertAutorise;
        }

        /// <summary>
        /// Renvoie l'objet sous la forme d'un string
        /// </summary>
        /// <returns>Un string qui représente l'état de l'instance</returns>
        public override string ToString()
        {
            return String.Format("numéro: {0}, nom: {1}, solde: {2}, découvert autorisé: {3}",
                this.numeroCompte, this.nomTitulaire, this.solde, this.decouvertAutorise);
        }

        /// <summary>
        /// Crédite de l'argent sur le compte
        /// </summary>
        /// <param name="_montant">Désigne le montant à créditer</param>
        public void Crediter(uint _montant)
        {
            this.solde += _montant;
        }

        /// <summary>
        /// Retire de l'argent sur ce compte en prenant en compte le découvert autorisé
        /// </summary>
        /// <param name="_montant">Désigne le montant à retirer</param>
        /// <returns>(true) si l'oppération à pu être effectuée, false sinon</returns>
        public bool Debiter(uint _montant)
        {            
            if (this.solde - _montant >= decouvertAutorise)
            {
                this.solde -= _montant;
                return true;
            }
            return false;
        }


        /// <summary>
        /// Transfere de l'argent vers un autre compte
        /// </summary>
        /// <param name="_montant">désigne la somme à envoyer</param>
        /// <param name="_destinataire">désigne le compte destinataire</param>
        /// <returns>un booleen qui désigne si l'oppération à réussie (true) ou échoué (false)</returns>
        /// <remarks>
        /// <see cref="Debiter(uint)"/>
        /// <see cref="Crediter(uint)"/>
        /// </remarks>
        public bool Transferer(uint _montant, Compte _destinataire)
        {
            if (Debiter(_montant))
            {
                _destinataire.Crediter(_montant);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compare le solde avec un autre compte
        /// </summary>
        /// <param name="_compare">désigne le compte à comparer</param>
        /// <returns>Si le solde de ce compte est suppérieur (true) sinon (false)</returns>
        public bool Supperieur(Compte _compare)
        {
            return this.solde >= _compare.solde;
        }
    }
}
