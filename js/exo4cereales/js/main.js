import { CerealsCollection } from "./CerealsCollection.js";

const collection = new CerealsCollection();
await collection.load().then(()=>{
    loadHeaderTableInfo();
});

function loadHeaderTableInfo(){
    let datas = collection.datas.data;
    let keys = Object.keys(datas[0]);
    console.log(keys);
    let element = document.querySelector('#firstLineOfTable');
    let tr = document.createElement('tr');
    keys.forEach(kn => {
        let th = document.createElement('th');
        th.innerHTML = kn;
        tr.appendChild(th);
    });
    console.log(tr.childElementCount);
    element.appendChild(tr);
}