import { ICommand } from "./ICommand.js";

class CommandLivrer extends ICommand{
    constructor(boulangerie, commande){
        super();
        this.boulangerie = boulangerie;
        this.commande = commande;
        this.date = new Date(Date.now());
        this.orGagne = commande.calculerPrixTotal();
        this.baguetteLivre = commande.qteDemande;
    }

    execute(){
        return this.commande.livrerCommande();
    }

    log(){
        let d = this.date.getHours() + ':' + this.date.getMinutes() + '.' + this.date.getSeconds();
        return d + ": La commande " + this.commande.numero + " a été livrée. Vous avez gagné "+ this.orGagne + " or et perdu " + this.baguetteLivre + " baguette" + (this.baguetteLivre > 1 ? "s": "") + "." ;
    }
}

export { CommandLivrer };