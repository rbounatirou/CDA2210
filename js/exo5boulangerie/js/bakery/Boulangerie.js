import { CommandAccepter } from './CommandAccepter.js';
import { Commande } from './Commande.js';
import { CommandLivrer } from './CommandLivrer.js';
import { CommandManager } from './CommandManager.js';
import { EnumEtatCommande } from './EnumEtatCommande.js';

class Boulangerie{
    constructor(){
        if (localStorage.getItem('boulangerie') != null){
            let resp = JSON.parse(localStorage.getItem('boulangerie'));
            this.qteOr = resp.qteOr;
            this.qteOrGagne = resp.qteOrGagne;
            this.nbMoulins = resp.nbMoulins;
            this.niveau = resp.niveau;
            this.qteFarine = resp.qteFarine;
            this.qteOrDepense = resp.qteOrDepense;
            this.qteFarineProduite = resp.qteFarineProduite;
            this.qteBaguetteProduite = resp.qteFarineProduite;
            this.qteBaguetteStock = resp.qteBaguetteStock;
            
        } else {
            this.qteOr = 200;
            this.nbMoulins = 1;
            this.qteFarine = 500;
            this.niveau = 1;
            this.qteBaguetteStock = 0;
            // Pour le debut
            this.qteOrGagne = 0;
            this.qteOrDepense = 0;
            this.qteFarineProduite = 0;
            this.qteBaguetteProduite = 0;
        }
        this.sesCommandes = [];
        this.activeCommandes = [];
        this.estOuverte = false;
        this.journal = new CommandManager();
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
        if (this.qteOr > price){
            this.qteOr -= price;
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

    sauvegarder(){
        if (this.estOuverte){
            this.fermerBoulangerie();
        }
        localStorage.setItem('boulangerie', JSON.stringify(this, ['qteOr', 'nbMoulins', 'niveau',
        'qteFarine', 'qteOrGagne', 'qteOrDepense', 'qteFarineProduite', 'qteBaguetteProduite', 'qteBaguetteStock']));
    }

    genererCommande(){
        //console.log(generer());
        if (this.sesCommandes.length  < 10){
            this.sesCommandes.push(new Commande(this));
        }
    }

    /**
     * 
     * @param {Commande} commande 
     */
    accepterCommande(commande){
        let com = this.sesCommandes.find(c => c.numero == commande.numero);
        if (com != undefined && this.journal.executerCommande(new CommandAccepter(this, commande))){
            this.activeCommandes.push(commande);
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
            this.produireFarine(); // D'abbord la farine car aucun besoin
            this.produireBaguette(); // Les baguettes ensuite car besoin de farine        
            
            for (let com of this.sesCommandes){
                com.controlerCommande();
            }

            // ON RETIRE LES COMMANDES INUTILES DANS LE ACTIVE COMMANDES
            this.activeCommandes.forEach((d,i) => {
                if (d.EnumEtatCommande != EnumEtatCommande.Accepte){
                    this.activeCommandes.splice(i,1);
                }
            });

            // ON TRAITE LES COMMANDES ACTIVES
            if (this.activeCommandes.length >= 0){
                this.manageActiveCommands();
            }
            
            // ON RETIRE LES COMMANDES INUTILES
            this.sesCommandes.forEach((d, i) => { 
                if (d.EnumEtatCommande != EnumEtatCommande.Accepte &&
                    d.EnumEtatCommande != EnumEtatCommande.EnAttente){
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
            this.qteOrGagne = Math.round(this.qteOrGagne*100)/100;
            // FAILLITE EVENTUELLE
            if (this.qteOr < 0){
                alert('Vous avez fait faillite ! :\'(');
            }

        }
    }

    manageActiveCommands(){
        if (!Array.isArray(this.activeCommandes) || this.activeCommandes.length <= 0)
            return;
        let rt= true;
        while (this.activeCommandes.length > 0 &&this.activeCommandes[0].qteDemande <= this.qteBaguetteStock &&
                rt ){                
                rt = this.journal.executerCommande(new CommandLivrer(this, this.activeCommandes[0]));
                if (rt){
                    //console.log('Livree');
                    let commande = this.activeCommandes[0];
                    this.qteBaguetteStock -= commande.qteDemande;
                    this.qteOrGagne += commande.calculerPrixTotal();
                    this.qteOr += commande.calculerPrixTotal();
                    this.activeCommandes.splice(0,1);
                }                
        } 
    }


    


}

export { Boulangerie };