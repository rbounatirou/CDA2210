import { ICommand } from "./ICommand.js";

class CommandAccepter extends ICommand{
    constructor(boulangerie, commande){
        super();
        this.boulangerie = boulangerie;
        this.commande = commande;
        this.date = new Date(Date.now());
    }

    execute(){
        return this.commande.accepterCommande();
    }

    log(){
        let d = this.date.getHours() + ':' + this.date.getMinutes() + '.' + this.date.getSeconds();
        return d + ": La commande " + this.commande.numero + " a été acceptée.";
    }
}

export { CommandAccepter };