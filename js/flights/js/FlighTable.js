import { Flight } from "./Flight.js";
import { FlightEvent } from './FlightEvent.js';
class FlightTable{
    constructor(sectionToLoad, collection){
        this.sectionToLoad = sectionToLoad;
        this.flightCollection = collection;
        this.orderAsc = true;
    }
    

    genererLigneEntete(){
        
        let tr = document.createElement('tr');
        tr.classList.add('orderable');
        this.flightCollection.data[0].getKeys().forEach(d=>{
            let th = document.createElement('th');
            th.innerText = this.genererEnteteName(d);
            th.dataset.name=d;
            tr.appendChild(th);
        });
        /*let th = document.createElement('th');
        th.innerText = "Flight total time";
        tr.appendChild(th);*/

        return tr;
        
    }

    genererEnteteName(key){
        let v = key.replace('_', ' ');
        let vs = v.split(' ');
        let str = '';
        
        vs.forEach((d,i) => str+= this.firstLetterOnUpper(d) + (i+1< vs.length ? ' ' : ''));
        return str;
    }

    firstLetterOnUpper(str){
        return str.charAt(0).toUpperCase() + str.substring(1, str.length).toLowerCase();
    }


    genererCellule(val){
        let td = document.createElement('td');
        td.innerText = val;
        return td;
    }

    /**
     * Genere une ligne relative à un élément
     * @param {Flight} element 
     */
    genererLigneCorps(element){
        let tr = document.createElement('tr');

        element.getValues().forEach((d,i)=>{
            if (element.getKeys()[i] !== "time_duration"){
                tr.appendChild(this.genererCellule(d));
            } else {
                let ellapsed = d/1000;
                let sec = ellapsed%60;
                let min = Math.floor(ellapsed/60)%60;
                let hour = Math.floor(ellapsed/3600);
                let str = hour + 'h' + min + 'm' + sec + 's';
                tr.appendChild(this.genererCellule(str));
            }
        });
        return tr;
    }

    actualiser(){

        this.sectionToLoad.innerHTML = "";
        let table = this.genererTableau();
        this.sectionToLoad.appendChild(table);
    }

    genererTableau(){
        
        let table = document.createElement('table');
        table.classList.add('flight-tab');        
        let thead = this.genererTHead();
        let tbody = this.genererTBody();
        table.appendChild(thead);
        table.appendChild(tbody);
        return table;

    }


    genererTHead(){
        let thead = document.createElement('thead');
        let ligne= this.genererLigneEntete();
        thead.appendChild(ligne);
        return thead;
    }

    genererTBody(){
        let tbody = document.createElement('tbody');
        this.flightCollection.data.forEach(d => {
            let tr = this.genererLigneCorps(d);
            tbody.appendChild(tr);
        });
        return tbody;
    }
}

export { FlightTable };