class Flight{
    constructor(from){
        Object.assign(this, from);
        this.time_duration = this.calculateTime();
    }

    getKeys(){
        return Object.keys(this);
    }

    getValues(){
        return Object.values(this);
    }

    calculateTime(){
        let d1 = new Date(this.start_time);
        let d2 = new Date(this.arrival_time);
        return d2.getTime() - d1.getTime();
    }
    
}

export { Flight };