using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBouteille
{
    public class Bouteille
    {
        /// <summary>
        /// désigne le diamètre du goulot en milimètres
        /// </summary>
        public float diametreGoulotMm { get; private set; }
        /// <summary>
        /// désigne le bouchon sur la bouteille
        /// </summary>
        public Bouchon bouchon { get; private set; } 
        /// <summary>
        /// désigne la capacité en litres de la bouteille
        /// </summary>
        public float capaciteEnLitre { get; private set; }
        /// <summary>
        /// désigne la contenance actuelle en litres de la bouteille
        /// </summary>
        public float contenanceActuelleEnLitres { get; private set; }


        /// <summary>
        /// Crée une instance de la bouteille avec les paramètres souhaités
        /// </summary>
        /// <param name="diametreGoulotMm">désigne le diamètre du goulot en milimètres</param>
        /// <param name="bouchon">désigne le bouchon sur la bouteille</param>
        /// <param name="capaciteEnLitre">désigne la capacité en litres de la bouteille</param>
        /// <param name="contenanceActuelleEnLitres">désigne la contenance actuelle en litres de la bouteille</param>
        public Bouteille(float diametreGoulotMm, Bouchon bouchon, float capaciteEnLitre, float contenanceActuelleEnLitres)
        {
            this.diametreGoulotMm = diametreGoulotMm;
            this.bouchon = (bouchon != null ? new Bouchon(bouchon) : null);
            this.capaciteEnLitre = capaciteEnLitre;
            this.contenanceActuelleEnLitres = contenanceActuelleEnLitres;
        }

        /// <summary>
        /// Constructeur par copie
        /// </summary>
        /// <param name="_from">Instance à copier</param>
        public Bouteille(Bouteille _from) : this(_from.diametreGoulotMm, _from.bouchon, _from.capaciteEnLitre, _from.contenanceActuelleEnLitres) { }        public Bouteille() : this(15, new Bouchon(15), 1.0f, 1.0f) { }

        /// <summary>
        /// Rempli la bouteille avec le volume d'eau désiré, peut échouer si la contenance théorique après ajout et supérieur à la capacite de
        /// la bouteille ou  si la bouteille est fermée, ou bien la quantite a Ajoute négative
        /// </summary>
        /// <param name="_litreAAjoute"></param>
        /// <returns>retourne un booléen, true si réussi false sinon</returns>
        public bool Remplir(float _litreAAjoute)
        {
            if (this.bouchon != null || 
                _litreAAjoute < 0 ||
               this.contenanceActuelleEnLitres + _litreAAjoute > capaciteEnLitre)
                return false;
            this.contenanceActuelleEnLitres += _litreAAjoute;
            return true;
            
        }

        /// <summary>
        /// Vide la bouteille du volume d'eau souhaitée, peut échouer si le volume à vider est suppérieur à la capaciteActuelle
        /// ou si la bouteille est fermée ou encore si la quantite à retirer est négative
        /// </summary>
        /// <param name="_litreARetire">Nombres de litres à retirer</param>
        /// <returns>true si la bouteille à pût être vidé, false sinon</returns>
        /// <example>
        /// <code>Vider(20.0f);</code>
        /// </example>
        public bool Vider(float _litreARetire)
        {
            if (this.bouchon != null ||
                _litreARetire < 0 ||
                this.contenanceActuelleEnLitres - _litreARetire < 0)
                return false;
            this.contenanceActuelleEnLitres-= _litreARetire;
            return true;
        }

        /// <summary>
        /// Ferme la bouteille, peut échouer si elle est déjà fermée ou si le bouchon à un diamètre incompatible
        /// </summary>
        /// <param name="_avec">Bouchon à utiliser pour fermer</param>
        /// <returns>renvoie un booleen true si la bouteille réussit sa fermeture, false sinon</returns>
        public bool Fermer(Bouchon _avec)
        {
            if (this.bouchon != null || _avec.diametreMm != this.diametreGoulotMm)
                return false;
            this.bouchon = _avec;
            return true;
        }

        /// <summary>
        /// Ouvre la bouteille, peut échouer si elle est déja ouverte
        /// </summary>
        /// <returns>renvoie un booleen true si réussi, false sinon</returns>
        public bool Ouvrir()
        {
            if (this.bouchon == null)
                return false;
            this.bouchon = null;
            return true;
        }
        /// <summary>
        /// Vide toute la bouteille, échoue si elle est fermée
        /// </summary>
        /// <returns>renvoie un booleen true si réussi, false sinon</returns>
        /// <remarks>
        /// <see cref="Vider(float)"/>
        /// </remarks>
        public bool ViderTout()
        {
            return this.Vider(this.contenanceActuelleEnLitres);
        }

        /// <summary>
        /// Remplit entierement la bouteille, échoue si elle est fermée
        /// </summary>
        /// <returns>renvoie un booleen true si réussi, false sinon</returns>
        /// <remarks>
        /// <see cref="Remplir(float)"/>
        /// </remarks>
        public bool RemplirTout()
        {
            return this.Remplir(this.capaciteEnLitre - this.contenanceActuelleEnLitres);
        }
    }
}
