import { LegumosCollection } from "./LegumosCollection.js";
import { Legumos } from "./Legumos.js";
import {LegumosTableEvent} from './LegumosTableEvent.js';

class LegumosTableGenerator{
    constructor(collection, section){
        this.section = section;
        this.collection = collection;
        this.headersInfos = [{from: 'Name', to: 'Nom'},
                    {from: 'Variety', to:  'Variete'},
                    {from: 'PrimaryColor', to : 'Couleur'},
                    {from: 'LifeTime', to: 'Durée Conservation'},
                    {from: 'Fresh', to: 'Frais'}];
        this.collection.onChange.push(()=>{
            this.actualiserAffichage();            
        });
        
    }

    actualiserAffichage(){        
        this.section.innerHTML = '';
        let table = this.generateTable();
        this.section.appendChild(table);
        
    }

    generateTable(){
        let table = document.createElement('table');
        table.classList.add('legumostable');
        let thead = this.generateTHead();
        let tbody = this.generateTBody();
        table.appendChild(thead);
        table.appendChild(tbody);
        LegumosTableEvent.loadEvent(this, table);
        return table;
    }

    generateTHead(){
        let thead = document.createElement('thead');
        let hline = this.generateTHeadLine();
        thead.appendChild(hline);
        return thead;
    }

    generateTHeadLine(){
        let tr = document.createElement('tr');
        tr.classList.add('theader-row');
        this.headersInfos.forEach(d=> {
            let th = this.generateCell(d.to, 'th');
            th.dataset.name = d.from;
            tr.appendChild(th);
        });
        let th = this.generateCell('Actions', 'th');
        th.classList.add('thaction');
        tr.appendChild(th);
        return tr;
    }

    generateTBody(){
        let tBody = document.createElement('tbody');
        this.collection.datas.forEach(d=>{
            let tr= this.generateTBodyLine(d);
            tBody.appendChild(tr);
        });
        return tBody;
    }

    generateTBodyLine(data){
        let tr = document.createElement('tr');
        this.headersInfos.forEach(hi => {
            let td = this.generateCell(hi.from !== 'Fresh' ?
             data[hi.from] : (data[hi.from] == 1 ? "oui" : "non"));
            tr.appendChild(td);
        });
        let td = document.createElement('td');
        let spanEdit = this.generateEditSpan(data);
    
        let spanDelete = this.generateDeleteSpan(data);
        td.appendChild(spanEdit);
        td.innerHTML += ' . ';
        td.appendChild(spanDelete);
        tr.appendChild(td);
        return tr;
    }

    generateClassSpan(data, label, className){
        let span = document.createElement('span');
        span.innerText = label;
        span.classList.add(className);
        span.dataset.id = data.Id;
        return span;
    }

    generateEditSpan(data){
        return this.generateClassSpan(data, 'Editer', 'editLegumos');
    }

    generateDeleteSpan(data){
        return this.generateClassSpan(data, 'Supprimer', 'deleteLegumos');
    }


    generateCell(value, type = 'td'){
        let cell = document.createElement(type);
        cell.innerText = value;
        return cell;
    }

}

export {LegumosTableGenerator}