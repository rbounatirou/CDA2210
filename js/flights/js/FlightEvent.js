class FlightEvent{
    static clickColumn(collection, data){
        if (typeof collection.data[0][data] !== "string"){
            collection.data.sort((a,b)=> a[data]-b[data]);
        } else {
            console.log("other");
            collection.data.sort((a,b)=> a[data].toString().localeCompare(b[data].toString()));
        }
    }
}

export {FlightEvent};