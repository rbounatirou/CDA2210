import {Zipcode} from './main.js'

const zipcodes = new Zipcode();
zipcodes.load();
const reg = new RegExp('^[0-9]{2,}$');
const reg2 = new RegExp('^[\\w -]{2,}$');
document.getElementById("coucou").addEventListener('keyup', event => {
    let value = event.target.value;
    if (reg.test(value)){            
        fillUi(zipcodes.searchByPostalCode(value)); 
        fillPropositionsWithPostalCode(zipcodes.searchLookLikePostalCode(value))       
    } else if (reg2.test(value)){
        fillUi(zipcodes.searchByCommuneName(value));
        fillPropositionsWithComuneName(zipcodes.searchLookLikeCommuneName(value))
    } else {
        document.querySelector('#cp-nom-list').innerHTML = "";
    }
});

function fillUi(results){
    
    //let element = document.getElementById('result');
    console.log(results);
    let element = document.querySelector('#areatoload');
    element.innerHTML = "";
    for (let city of results){
        let tr = document.createElement('tr');
        let td_nomCommune = document.createElement('td');
        let td_codeCommune = document.createElement('td');
        let td_codePostal = document.createElement('td');
        let td_libelle = document.createElement('td')
        td_nomCommune.innerText = city.nomCommune;
        td_codeCommune.innerText = city.codeCommune;
        td_codePostal.innerText = city.codePostal;
        td_libelle.innerText = city.libelleAcheminement;
        tr.appendChild(td_codePostal);
        tr.appendChild(td_codeCommune);
        tr.appendChild(td_nomCommune);
        tr.appendChild(td_libelle);
        element.appendChild(tr);
    }
}

function fillPropositionsWithComuneName(results){
    let element = document.querySelector('#cp-nom-list');
    element.innerHTML = "";
    console.log(results);
    for (let el of results){
        let opt = document.createElement('option');
        opt.value = el.nomCommune;
        element.appendChild(opt);
    }
}

function fillPropositionsWithPostalCode(results){
    let element = document.querySelector('#cp-nom-list');
    element.innerHTML = "";
    console.log(results);
    
    for (let el of results){
        let opt = document.createElement('option');
        opt.value = el.codePostal;
        element.appendChild(opt);
    }
}