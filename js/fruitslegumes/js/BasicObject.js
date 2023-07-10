class BasicObject{
    constructor(props){
        Object.assign(this, props);
    }

    getKeys(){
        return Object.keys(this);
    }

    getValues(){
        return Object.values(this);
    }
}

export { BasicObject };