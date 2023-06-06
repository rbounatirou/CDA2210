class Cereal{
    constructor(card){
        Object.assign(this, card);
    }

    getKeys(){
        return Object.keys(this);
    }

    getValues(){
        return Object.values(this);
    }

}

export { Cereal };