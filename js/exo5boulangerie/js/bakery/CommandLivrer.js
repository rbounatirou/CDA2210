import { ICommand } from "./ICommand.js";

class CommandLivrer extends ICommand{
    constructor(boulangerie, commande){
        this.boulangerie = boulangerie;
        this.commande = commande;
    }

    execute(){
        return this.boulangerie.LivrerCommande(commande);
    }
}

export { CommandLivrer };