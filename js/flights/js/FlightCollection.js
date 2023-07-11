import { Flight } from "./Flight.js";
import { Db } from "./Db.js";

class FlightCollection{
    constructor(){
        this.data = [];
    }
    
    async load(){
        let json = await Db.fetchData('https://arfp.github.io/tp/web/frontend/flights/flights.json');
        this.data = json.map(d=> new Flight(d));
    }

}

export { FlightCollection };