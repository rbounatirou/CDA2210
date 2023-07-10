import { LegumosTableGenerator } from "./LegumosTableGenerator.js"

//Genere les evenement de la table

class LegumosTableEvent{
    static orderASC = true;
    /**
     * 
     * @param {LegumosTableGenerator} tableLegumos 
     */

    static loadEvent(tableLegumos, tableHTML){
        tableHTML.querySelectorAll('.deleteLegumos').forEach(d=>d.addEventListener(
            'click', e=>{
                console.log(e.target);
                tableLegumos.collection.deleteByID(e.target.dataset.id);
            })
        );
        tableHTML.querySelectorAll('.theader-row>th:not(.thaction)').forEach(d=>d.addEventListener(
            'click', e=>{
                tableLegumos.collection.sortByColumnName(e.target.dataset.name, LegumosTableEvent.orderASC);
                LegumosTableEvent.orderASC = !LegumosTableEvent.orderASC;
            }
        ));
    }
}

export {LegumosTableEvent};