import { Commande } from './Commande.js';
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
            this.estOuverte = true;
            this.qteBaguetteStock = 0;
            this.sesCommandes = [];
            this.activeCommandes = [];
            this.refuseComandes = [];
            this.journal = new CommandManager();
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
        return Math.floor(80 * Math.pow(1.5,this.nbMoulins));
    }

    getPriceForNextBakeryLevel(){
        return Math.floor(100 * Math.pow(1.5, this.niveau));
    }
    
    ajouterMoulin(){
        let price = this.getPriceForNextMill();
        if (qteOr > price){
            qteOr -= price;
            this.nbMoulins+=1;
            return true;
        }
        return false;
    }

    produireFarine(){
        this.qteFarine += this.nbMoulins;
    }

    produireBaguette(){
        if (this.qteFarine >= (this.niveau + 1)){
            this.qteFarine -= (this.niveau + 1);
            this.qteBaguetteStock += this.niveau;
            return true;
        }
        return false;
    }

    effectuerMaintenance(){
        let priceEachSeconds = 0.05 * this.niveau * this.nbMoulins;
        if (this.qteOr > priceEachSeconds){
            qteOr -= price;
            return true;
        }
        return false;
    }

    augmenterNiveau(){
        let price = this.getPriceForNextBakeryLevel();
        if (this.qteOr >= price){
            this.qteOr -= price;
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

    doEverySecondJob(){
        if (this.estOuverte && this.qteOr >= 0){  
            // ON FAIT LES PRODUCTIONS DE MATIERE PREMIERE
            this.produireFarine();
            this.produireBaguette();

            
            // GESTION DES COMMANDES NON TENUE ET NON TRAITE
            // On regarde si les commandes sont termines
            for (let com of this.sesCommandes){
                com.ControlerCommande();
            }
            this.sesCommandes.forEach((d, i) => { if (d.EnumEtatCommande == EnumEtatCommande.NonGere) {
                this.sesCommandes.splice(i,1);
            }});            

            // ON TRAITE LES COMMANDES TRAITE
            for (let i = this.activeCommandes.length -1; i >= 0; i--){
                if (com.qteDemande <= this.qteBaguetteStock && com.LivrerCommande()){
                    this.qteBaguetteStock -= com.qteDemande;
                    
                }
            }         
           

            // LES MAINTENANCES
            this.effectuerMaintenance();
            // FAILLITE EVENTUELLE
            if (this.qteOr < 0){
                alert('Vous avez fait faillite ! :\'(');
            }

        }
    }
    


}

export { Boulangerie };