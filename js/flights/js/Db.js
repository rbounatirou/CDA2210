/* CLASSE CHARGEE DE
RECUPERER LES DONEES DEPUIS UNE SOURCE VIA
SA METHODE FETCHDATA EN LES RENVOYANT SOUS UN FORMAT JSON */

class Db{
    static async fetchData(source){
        let datas= await fetch(source);
        return await datas.json();
    }
}

export { Db };