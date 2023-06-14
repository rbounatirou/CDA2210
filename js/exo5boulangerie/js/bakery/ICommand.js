class ICommand{
    /**
     * 
     * @returns { Boolean }
     */
    execute() {
        return false;
    }

    log(){
        return "";
    }
}

export { ICommand };