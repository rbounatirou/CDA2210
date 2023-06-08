import { Commande } from './Commande.js';
import { CommandLivrer } from './CommandLivrer.js';
import { CommandManager } from './CommandManager.js';
import { EnumEtatCommande } from './EnumEtatCommande.js';

class Boulangerie{
    constructor(){
        if (localStorage.getItem('boulangerie') != null){

        } else {
            this.qteOr = 200;
            this.nbMoulins = 1;
            this.qteFarine = 500;
            this.niveau = 1;
            this.estOuverte = false;
            this.qteBaguetteStock = 0;
            this.sesCommandes = [];
            this.activeCommandes = [];
            this.refuseComandes = [];
            this.journal = new CommandManager();
            // Pour le debut
            this.qteOrGagne = 0;
            this.qteOrDepense = 0;
            this.qteFarineProduite = 0;
            this.qteBaguetteProduite = 0;
        }
    }

    fermerBoulangerie(){
        if (this.estOuverte){
            this.estOuverte = false;
            return true;
        }
        return false;
    }

    ouvrirBoulangerie(){
        if (!this.estOuverte){
            this.estOuverte = true;
            return true;
        }
        return false;
    }

    getPriceForNextMill(){
        return Math.round(80 * Math.pow(1.5,(this.nbMoulins-1)) * 100)/100;
    }

    getPriceForNextBakeryLevel(){
        return Math.round(100 * Math.pow(1.5, (this.niveau-1)) * 100 ) / 100;
    }
    
    ajouterMoulin(){
        let price = this.getPriceForNextMill();
        if (qteOr > price){
            qteOr -= price;
            this.qteOrDepense += price;
            this.nbMoulins+=1;
            return true;
        }
        return false;
    }

    produireFarine(){
        this.qteFarine += this.nbMoulins;
        this.qteFarineProduite += this.nbMoulins;
    }

    produireBaguette(){
        if (this.qteFarine >= (this.niveau + 1)){
            this.qteFarine -= (this.niveau + 1);
            this.qteBaguetteStock += this.niveau;
            this.qteBaguetteProduite += this.niveau;
            return true;
        }
        return false;
    }

    getPrixMaintenance(){
        return Math.round(0.05 * this.niveau * this.nbMoulins * 100) / 100;
    }

    effectuerMaintenance(){
        let priceEachSeconds = this.getPrixMaintenance();
        console.log(priceEachSeconds);
        if (this.qteOr > priceEachSeconds){
            this.qteOr -= priceEachSeconds;
            this.qteOrDepense += priceEachSeconds;
            return true;
        }
        return false;
    }

    augmenterNiveau(){
        let price = this.getPriceForNextBakeryLevel();
        if (this.qteOr >= price){
            this.qteOr -= price;
            this.qteOrDepense += price;
            this.niveau += 1;
            return true;
        }
        return false;
    }

    genererCommande(){
        
        if (this.sesCommandes.length + this.activeCommandes.length + this.refuseComandes.length <= 10){
            this.sesCommandes.push(new Commande(this));
        }
    }

    /**
     * 
     * @param {Commande} commande 
     */
    accepterCommande(commande){
        let com = this.sesCommandes.find(c => c.numero == commande.numero);
        if (com != undefined && com.accepterCommande()){
            
            return true;
        }
        return false;
    }

    refuserCommande(commande){
        let com = this.sesCommandes.find(c => c.numero == commande.numero);
        if (com != undefined && com.refuserCommande()){
            return true;
        }
        return false;
    }

    doEverySecondJob(){
        if (this.estOuverte && this.qteOr >= 0){  
            // ON FAIT LES PRODUCTIONS DE MATIERE PREMIERE
            this.produireFarine();
            this.produireBaguette();

            
            // GESTION DES COMMANDES NON TENUE ET NON TRAITE
            // On regarde si les commandes sont termines

             // ON TRAITE LES COMMANDES TRAITE
             for (let i = this.activeCommandes.length -1; i >= 0; i--){
                if (com.qteDemande <= this.qteBaguetteStock && this.journal.executerCommande(new CommandLivrer(this, com))){
                    this.qteBaguetteStock -= com.qteDemande;
                    this.qteOr += com.calculerPrixTotal();
                    this.activeCommandes.splice(i,1);
                }
            }

            /*this.sesCommandes.forEach((d, i) => { if (d.EnumEtatCommande == EnumEtatCommande.NonGere || d.EnumEtatCommande == EnumEtatCommande.NonTenue || EnumEtatCommande.Livre) {
                this.sesCommandes.splice(i,1);
            }}); */
            for (let com of this.sesCommandes){
                com.controlerCommande();
            }     
            this.sesCommandes.forEach((d, i) => { 
                if (d.EnumEtatCommande == EnumEtatCommande.NonGere){
                    this.sesCommandes.splice(i,1);
                }
            });
            for (let com of this.sesCommandes){
                com.reduireTimer();
            }  
            
            this.genererCommande();

                    
            // LES MAINTENANCES
            this.effectuerMaintenance();
            this.qteOr = Math.round(this.qteOr * 100)/100;
            this.qteOrDepense = Math.round(this.qteOrDepense *100)/100;
            // FAILLITE EVENTUELLE
            if (this.qteOr < 0){
                alert('Vous avez fait faillite ! :\'(');
            }

        }
    }


    


}

export { Boulangerie };