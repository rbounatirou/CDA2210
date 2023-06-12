import { ICommand } from "./ICommand.js";
import { Boulangerie } from "./Boulangerie.js";

class CommandAugmenterMoulin extends ICommand{
    /**
     * 
     * @param {Boulangerie} boulangerie 
     */
    constructor(boulangerie){
        super();
        this.boulangerie = boulangerie;
        this.initialNiveau = boulangerie.nbMoulins;
        this.cout = boulangerie.getPriceForNextMill();
        this.date = new Date(Date.now());
    }

    execute(){
        return this.boulangerie.ajouterMoulin();
    }

    log(){
        let d = this.date.getHours() + ':' + this.date.getMinutes() + '.' + this.date.getSeconds();
        return d+ " La boulangerie a augmenter son nombre de moulins pour " + this.cout + " or. (moulins " +
            this.initialNiveau + "->" + (this.initialNiveau+1) + ").";
    }
}

export {CommandAugmenterMoulin};