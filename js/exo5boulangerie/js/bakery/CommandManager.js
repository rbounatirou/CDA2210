import { ICommand } from "./ICommand.js";

class CommandManager{
    constructor(){
        this.commands = [];
        this.eventChange = [];
    }
    /**
     * 
     * @param { ICommand } command 
     */
    executerCommande(command)
    {
        let execRt = command.execute();
        if (execRt){
            this.commands.splice(0,0,command);
            this.eventChange.forEach(element => {
                element();
            });
        }
        return execRt;
    }

    
}

export { CommandManager };