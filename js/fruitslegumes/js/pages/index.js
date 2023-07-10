import { LegumosCollection } from "../legumos/LegumosCollection.js";
import { LegumosTableGenerator } from "../legumos/LegumosTableGenerator.js";


await execute();

async function execute(){
    const collection = new LegumosCollection();
    await collection.load();
    const table = new LegumosTableGenerator(collection, document.querySelector('#sectionToLoad'));
    table.actualiserAffichage();
}