import { Db } from "../Db.js";
import { Legumos } from './Legumos.js'

class LegumosCollection{
    constructor(){
        this.datas= [];
        this.onChange = [];
    }

    async load(){
        let json = localStorage.getItem('legumosCollection');
        
        if (json == null){
            json = await Db.fetchData('https://arfp.github.io/tp/web/frontend/grocery/legumos.json');
        }
        this.datas = json.map(d => new Legumos(d));
    }
    
    save(){
        localStorage.setItem('legumosCollection', JSON.stringify(this.datas));
    }

    /**
     * 
     * @param {Legumos} legumosToAdd 
     */
    addLegumos(legumosToAdd){
        this.datas.push(legumosToAdd);
        this.onChange.forEach(d=>d());
    }

    /**
     * 
     * @param {String} columnName 
     * @param {Boolean} orderAsc 
     * @returns 
     */
    sortByColumnName(columnName, orderAsc = true){
        //console.log(typeof this.datas[0][columnName]);
        let type = typeof this.datas[0][columnName];
        console.log(type);
        if (this.datas.length == 0)
            return;
        if (type === 'string'){
            this.datas.sort((a,b) => a[columnName].toString().localeCompare(b[columnName].toString()));
         
        } else if (type === 'number'){            
            this.datas.sort((a,b)=> a[columnName]-b[columnName]);   
        } else {            
            this.datas.sort((a,b) => (a===b) ? 0 : (a ? -1 : 1));
        }
        if (!orderAsc){
            this.datas.reverse();
        }
        this.onChange.forEach(d=>d());
    }

    deleteByID(id){
        let length = this.datas.length;
        this.datas = this.datas.filter(d=> d.Id != id);
        if (length != this.datas.length){
            this.onChange.forEach(d=>d());
        }
    }


}

export {LegumosCollection};