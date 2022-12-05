using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBouteille
{
    internal class Bouteille
    {
        /// <summary>
        /// désigne le diamètre du goulot en milimètres
        /// </summary>
        private float diametreGoulotMm;
        /// <summary>
        /// désigne le bouchon sur la bouteille
        /// </summary>
        private Bouchon bouchon;
        /// <summary>
        /// désigne la capacité en litres de la bouteille
        /// </summary>
        private float capaciteEnLitre;
        /// <summary>
        /// désigne la contenance actuelle en litres de la bouteille
        /// </summary>
        private float contenanceActuelleEnLitres;


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
            this.bouchon = bouchon;
            this.capaciteEnLitre = capaciteEnLitre;
            this.contenanceActuelleEnLitres = contenanceActuelleEnLitres;
        }

        public Bouteille() : this(15, new Bouchon(15), 1.0f, 1.0f) { }

        /// <summary>
        /// Rempli la bouteille avec le volume d'eau désiré, peut échouer si la contenance théorique après ajout et supérieur à la capacite de
        /// la bouteille ou  si la bouteille est fermée, ou bien la quantite a Ajoute négative
        /// </summary>
        /// <param name="_litreAAjoute"></param>
        /// <returns></returns>
        public bool Remplir(float _litreAAjoute)
        {
            if (bouchon != null || 
                _litreAAjoute < 0 ||
               contenanceActuelleEnLitres + _litreAAjoute > capaciteEnLitre)
                return false;
            this.contenanceActuelleEnLitres += _litreAAjoute;
            return true;
            
        }

        /// <summary>
        /// Vide la bouteille du volume d'eau souhaitée, peut échouer si le volume a vider est suppérieur à la capaciteActuelle
        /// ou si la bouteille est fermée ou encore si la quantite à retirer est négative
        /// </summary>
        /// <param name="_litreARetire">Nombres de litres à retirer</param>
        /// <returns>true si la bouteille à pût être vidé, false sinon</returns>
        public bool Vider(float _litreARetire)
        {
            if (bouchon != null ||
                _litreARetire < 0 ||
                contenanceActuelleEnLitres - _litreARetire < 0)
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
            if (bouchon != null || _avec.diametreMm != diametreGoulotMm)
                return false;
            bouchon = _avec;
            return true;
        }

        /// <summary>
        /// Ouvre la bouteille, peut échoué si elle est déja ouverte
        /// </summary>
        /// <returns>renvoie un booleen true si réussi, false sinon</returns>
        public bool Ouvrir()
        {
            if (bouchon == null)
                return false;
            bouchon = null;
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
            this.Vider(this.contenanceActuelleEnLitres);
            return true;
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
            this.Remplir(this.capaciteEnLitre - this.contenanceActuelleEnLitres);
            return true;
        }
    }
}
