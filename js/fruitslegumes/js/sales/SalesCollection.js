import { Db } from "../Db.js";
import { Sale } from "./Sale.js";

class SalesCollection{
    constructor(){
        this.data = [];
    }

    async load(){
        let json = localstorage.getItem('saleCollection');
        if (json == null){
            json = await Db.fetchData('https://arfp.github.io/tp/web/frontend/grocery/legumos-sales.json');
        }
        this.data = json.map(d=> new Sale(d));
    }

    save(){
        localStorage.setItem('saleCollection', JSON.stringify(this.data));
    }

    /**
     * 
     * @param {Sale} saleToAdd 
     */
    addSale(saleToAdd){
        this.data.push(saleToAdd);
    }
}

export { SalesCollection };