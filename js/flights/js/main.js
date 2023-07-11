import { FlightCollection } from "./FlightCollection.js";
import { FlightTable } from "./FlighTable.js";
import { FlightEvent } from "./FlightEvent.js";

const collection = new FlightCollection();
await collection.load();
const flightTable = new FlightTable(document.querySelector('#sectionTable'), collection);
flightTable.actualiser();

let orderAsc = true;

ajouterEvent();

function ajouterEvent(){
    document.querySelectorAll('.orderable>th').forEach(e=>{
        e.addEventListener('click', ev=>{
            FlightEvent.clickColumn(collection, ev.target.dataset.name);
            if (!orderAsc){
                collection.data.reverse();
            }
            orderAsc = !orderAsc;
            flightTable.actualiser();

            ajouterEvent();
        });
    });
}