import { CerealsCollection } from "./CerealsCollection.js";

const collection = new CerealsCollection();
await collection.load().then(()=>{
    loadHeaderTableInfo();
    loadAllElement();
    document.querySelector('#searchCereal').addEventListener('keyup', e=> {
        loadCerealList(e.target);
        reset();
    });
    document.querySelector('#nutriscoreField').querySelectorAll('.nutribox').forEach(d => 
        {
            d.addEventListener('click', () => {
                reset();
            });
        }
    );
    document.querySelector('#saveBt').addEventListener('click',()=>{saveData();})
    document.querySelector('#reloadBt').addEventListener('click',()=>{reloadData();})
    document.querySelector('#categoriesList').addEventListener('change', () => reset());

    loadDataFromNutriscores();
});

function reset(){
    document.querySelector('#bodyOfTable').innerHTML = "";
    loadAllElement();
}

function loadHeaderTableInfo(){
    let datas = collection.datas.data;
    let keys = Object.keys(datas[0]);
    //console.log(keys);
    let element = document.querySelector('#firstLineOfTable');
    let tr = document.createElement('tr');
    keys.forEach(kn => {
        let th = document.createElement('th');
        th.innerHTML = kn.toUpperCase();
        tr.appendChild(th);
    });
    let thNs = document.createElement('th');
    let thDel = document.createElement('th')
    thNs.innerHTML= 'NS';
    thDel.innerHTML = 'DEL';
    tr.appendChild(thNs);
    tr.appendChild(thDel);
    //console.log(tr.childElementCount);
    //console.log(tr);
    //console.log(element);
    element.appendChild(tr);
}

function getElementByFilterCategorie(){
    return getElementByFilterCategorieFromData(collection.datas.data);
}

function getElementByFilterCategorieFromData(datas){    
    let selectValue = document.querySelector('#categoriesList').value;
    let rt = datas;
    console.log(selectValue);
    if (selectValue == "1") {
        rt = datas.filter(d=> d.sugars < 1);
    } else if (selectValue == "2") {
        rt = datas.filter(d => d.sodium < 50);
    } else if (selectValue == "3") {
        rt = datas.filter(d=> d.vitamins >= 25 && d.fiber >= 10 );
    }
    return rt;
}

function loadDataFromNutriscores(){
    loadDataFromNutriscoresFromData(collection.datas.data);
}

function loadDataFromNutriscoresFromData(datas){
    let nutriscoreField = document.querySelector('#nutriscoreField').getElementsByClassName('nutribox');
    let mustLoad = false;
    let i = 0;
    while(!mustLoad && i < nutriscoreField.length){
        mustLoad = nutriscoreField[i].checked;
        i+=1;
        
    }
    if (mustLoad==true){
        let possible = [];
        possible.push([]);
        if (document.querySelector('#nutriA').checked)
            possible[0].push(dataNutriA(datas));
        if (document.querySelector('#nutriB').checked)
            possible[0].push(dataNutriB(datas));
        if (document.querySelector('#nutriC').checked)
            possible[0].push(dataNutriC(datas));
        if (document.querySelector('#nutriD').checked)
            possible[0].push(dataNutriD(datas));
        if (document.querySelector('#nutriE').checked)
            possible[0].push(dataNutriE(datas));
        let rt = [];
        possible[0].forEach(d=>console.log(d));
        possible[0].forEach(d=> rt =rt.concat(d));
        console.log(rt);
        return rt;
    }
    return datas;
}


function loadDataWithFilters(){
    let value = document.querySelector('#searchCereal').value;
    //console.log(value);
    let datas = (value != "" ? looklike(value) : collection.datas.data);
    datas = applySecondaryFiter(datas);
    return datas;
}

function applySecondaryFiter(datas){
    let rt = loadDataFromNutriscoresFromData(datas);
    rt = getElementByFilterCategorieFromData(rt);
    return rt;
}

function loadAllElement(){
    let datas = loadDataWithFilters();
    let element = document.querySelector('#bodyOfTable');
    if (Array.isArray(datas) && datas.length > 0){
        datas.forEach(d => {
            let tr = document.createElement('tr');
            let value = Object.values(d);
            let keys = Object.values(d);
            let td = [];
            for (let v of value){
                let td = document.createElement('td');
                td.innerHTML = v;
                tr.appendChild(td);
            }
            let tdNs = document.createElement('td');
            let ns = calculateNutriscore(d);
            tdNs.classList.add('nutriscore');
            tdNs.classList.add(ns);
            
            tdNs.innerHTML = ns;
            tr.appendChild(tdNs);
            let tdDel = document.createElement('td');
            let labelDel = document.createElement('label');
            labelDel.innerHTML='X';
            tdDel.appendChild(labelDel);
            tr.appendChild(tdDel);
            labelDel.addEventListener('click', e=> {
                collection.remove(d.id);
                element.innerHTML="";
                loadAllElement();
            });
            element.appendChild(tr);
        });
    }
    loadFooter(datas);
}


function loadFooter(datas)
{
    let element = document.querySelector('#bodyOfTable');
    // --
    let tr = document.createElement('tr');
    let tdid = document.createElement('td');
    
    let tdname = document.createElement('td');
    tdname.innerHTML =  datas.length + ' éléments';
    let tdcalories = document.createElement('td');
    tdcalories.innerHTML = 'Moyenne calories ' + getAverageCalories(datas);
    // --
    let tdcaloriesColSpan = Object.keys(collection.datas.data[0]).length;
    tdcalories.colSpan  = tdcaloriesColSpan -2;
    tr.appendChild(tdid);
    tr.appendChild(tdname);
    tr.appendChild(tdcalories);
    element.appendChild(tr);

}


function getAverageCalories(datas){
    let sum = 0;
    datas.forEach(d=> sum+=d.calories);
    return Math.round(sum/datas.length);
}

function calculateNutriscore(data){
    if (data.rating > 80){
        return 'A';
    } else if (data.rating >= 70 && data.rating <= 80){
        return 'B';
    } else if (data.rating >= 55 && data.rating < 70){
        return 'C';
    } else if (data.rating >= 35 && data.rating < 55){
        return 'D';
    } else {
        return 'E';
    }
}

function dataNutriA(datas){
    return datas.filter(d=> d.rating > 80)
}

function dataNutriB(datas){
    return datas.filter(d=> d.rating >= 70 && d.rating <= 80);
}

function dataNutriC(datas){
    return datas.filter(d=> d.rating >= 55 && d.rating < 70);
}

function dataNutriD(datas){
    return datas.filter(d=> d.rating >= 35 && d.rating < 55);
}

function dataNutriE(datas){
    return datas.filter(d=> d.rating < 35);
}

function loadCerealList(element){
    let datalist = document.querySelector('#cerealList');
    datalist.innerHTML="";
    let datas = looklike(element.value);
    datas.forEach(d => {
        let option = document.createElement('option');
        option.value = d.name;
        datalist.appendChild(option);
    });
   
}

function looklike(str){
    let datas = collection.datas.data;
    datas = applySecondaryFiter(datas);
    return datas.filter(d=> d.name.toLowerCase().includes(str.toLowerCase()));
}

function saveData(){
    let dataSave = JSON.stringify(loadDataWithFilters());
    console.log(dataSave);
    localStorage.setItem('savedDatas', dataSave);
}

function reloadData(){
    localStorage.removeItem('savedDatas');
    collection.load().then(()=>reset());
}