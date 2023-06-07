import { ICommand } from "./ICommand.js";

class CommandAccepter extends ICommand{
    constructor(boulangerie, commande){
        this.boulangerie = boulangerie;
        this.commande = commande;
    }

    execute(){
        return this.boulangerie.AccepterCommande(commande);
    }
}

export { CommandAccepter };