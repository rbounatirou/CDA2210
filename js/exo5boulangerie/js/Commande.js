import { EnumEtatCommande } from "./EnumEtatCommande.js";

class Commande{
    constructor(bakery){
        this.numero = "";
        this.prixUnitaire = 0.0;
        this.qteDemande = 1;
        this.EnumEtatCommande = EnumEtatCommande.EnAttente;
        this.dateFin = Date.now() + (10+(Math.floor(Math.random() * 51))*1000); // entre 10 et 60 seconds pour accepter ou refuser la commande
    }

    RefuserCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.EnAttente)
        {
            this.EnumEtatCommande = EnumEtatCommande.Refuse;
            return true;
        }
        return false;
    }

    AccepterCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.EnAttente){
            this.EnumEtatCommande = EnumEtatCommande.Accepte;
            this.dateFin = Date.now() + 90000; // pour laisser 90 seconds à l'utilisateur afin de livrer la commande
            return true;
        }
        return false;
    }
    

    LivrerCommande(){
        if (this.EnumEtatCommande == EnumEtatCommande.Accepte){
            this.EnumEtatCommande = EnumEtatCommande.Livre;
            return true;
        }
        return false;
    }

    ControlerCommande(){
        if (this.dateFin > Date.now()){
            if (this.EnumEtatCommande == EnumEtatCommande.EnAttente){
                this.EnumEtatCommande = EnumEtatCommande.NonGere;
            } else if (this.EnumEtatCommande == EnumEtatCommande.Accepte){
                this.EnumEtatCommande = EnumEtatCommande.NonTenue;
            }
        }
    }

}

export {Commande};