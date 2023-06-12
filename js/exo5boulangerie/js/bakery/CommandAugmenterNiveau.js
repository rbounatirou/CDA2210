import { ICommand } from "./ICommand.js";
import { Boulangerie } from "./Boulangerie.js";

class CommandAugmenterNiveau extends ICommand{
    /**
     * 
     * @param {Boulangerie} boulangerie 
     */
    constructor(boulangerie){
        super();
        this.boulangerie = boulangerie;
        this.initialNiveau = boulangerie.niveau;
        this.cout = boulangerie.getPriceForNextBakeryLevel();
        this.date = new Date(Date.now());
    }

    execute(){
        return this.boulangerie.augmenterNiveau();
    }

    log(){
        let d = this.date.getHours() + ':' + this.date.getMinutes() + '.' + this.date.getSeconds();
        return d + " La boulangerie a augmenter son niveau pour " + this.cout + " or. (niveau " +
            this.initialNiveau + "->" + (this.initialNiveau+1) +")";
    }
}

export {CommandAugmenterNiveau};