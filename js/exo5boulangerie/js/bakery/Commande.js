import { EnumEtatCommande } from "./EnumEtatCommande.js";
import { Boulangerie } from "./Boulangerie.js"

var nbCommandes = 0;
class Commande{

    /**
     * 
     * @param {Boulangerie} bakery 
     */
    constructor(bakery){
        this.numero = nbCommandes;
        nbCommandes++;
        // QTE
        let minPrice = bakery.niveau; // a diviser par 100
        let maxPrice = bakery.niveau * 30 ; // a diviser par 100

        this.prixUnitaire = Math.round(minPrice + (Math.random() * (maxPrice+1-minPrice)))/100;

        let minBaguette = 5;
        let maxBaguettes = 30 * bakery.niveau;

        this.qteDemande = Math.round(minBaguette + (Math.random() * (maxBaguettes-minBaguette+1)));
        this.EnumEtatCommande = EnumEtatCommande.EnAttente;

        this.tempsRestant = (10+(Math.floor(Math.random() * 51)));
        
    }

    refuserCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.EnAttente)
        {
            this.EnumEtatCommande = EnumEtatCommande.Refuse;
            return true;
        }
        return false;
    }

    accepterCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.EnAttente){
            this.EnumEtatCommande = EnumEtatCommande.Accepte;
            this.tempsRestant = 90; // pour laisser 90 seconds à l'utilisateur afin de livrer la commande
            return true;
        }
        return false;
    }
    

    livrerCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.Accepte){
            this.EnumEtatCommande = EnumEtatCommande.Livre;
            return true;
        }
        return false;
    }

    controlerCommande(){
        if (this.tempsRestant <= 0){
            if (this.EnumEtatCommande == EnumEtatCommande.EnAttente){
                this.EnumEtatCommande = EnumEtatCommande.NonGere;
            } else if (this.EnumEtatCommande == EnumEtatCommande.Accepte){
                this.EnumEtatCommande = EnumEtatCommande.NonTenue;
            }
        }
    }

    calculerPrixTotal(){
        return Math.round(this.prixUnitaire * this.qteDemande*100)/100;
    }


    reduireTimer(){
        this.tempsRestant -= 1;
    }

}

export {Commande};