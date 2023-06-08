import { ICommand } from "./ICommand.js";

class CommandManager{
    constructor(){
        this.commands = [];
    }
    /**
     * 
     * @param { ICommand } command 
     */
    executerCommande(command)
    {
        let execRt = command.execute();
        if (execRt){
            this.commands.push(command);
        }
        return execRt;
    }
}

export { CommandManager };