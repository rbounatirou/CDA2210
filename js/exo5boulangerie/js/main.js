import { Boulangerie } from './bakery/Boulangerie.js';
import { EnumEtatCommande } from './bakery/EnumEtatCommande.js';
const bl = new Boulangerie();

majIHM();

document.querySelector('#openclosebt').addEventListener('click',e=>{
    console.log(e.target);
    if (bl.estOuverte){
        bl.fermerBoulangerie();
        e.target.innerHTML = "Ouvrir boulangerie";
    } else {
        bl.ouvrirBoulangerie();
        e.target.innerHTML = "Fermer boulangerie";
    }
});

setInterval( () => {
    bl.doEverySecondJob();
    majIHM();
}, 1000);;


function majIHM(){
    majHeader();
    majInfos();
    majCommandes();
}

function majHeader(){
    let el = document.querySelector('#statsEntete');
    el.innerHTML = "";
    el.appendChild(generateTdWithValue(bl.qteOrGagne))
    el.appendChild(generateTdWithValue(bl.qteOrDepense));
    el.appendChild(generateTdWithValue(bl.qteFarineProduite));
    el.appendChild(generateTdWithValue(bl.qteBaguetteProduite));
}

function majInfos(){
    let elNiveauLabel = document.querySelector('#boulangerieNiveau');
    let elMoulinLabel = document.querySelector('#moulinsNombre');
    let elBakeryNextPrice = document.querySelector('#boulangerieNextPrice');
    let elMoulinNextPrice = document.querySelector('#moulinsNextPrice');
    let elQteOr = document.querySelector('#quantiteOr');
    let elQteFarine = document.querySelector('#quantiteFarine');
    let elQteBaguette = document.querySelector('#quantiteBaguette');
    elNiveauLabel.innerHTML = bl.niveau;    
    elMoulinLabel.innerHTML = bl.nbMoulins;
    elBakeryNextPrice.innerHTML = bl.getPriceForNextBakeryLevel();
    elMoulinNextPrice.innerHTML = bl.getPriceForNextMill();
    elQteOr.innerHTML = bl.qteOr;
    elQteFarine.innerHTML = bl.qteFarine;
    elQteBaguette.innerHTML = bl.qteBaguetteStock;
}

function generateTdWithValue(value){
    let td = document.createElement('td');
    td.innerHTML =  value;
    return td;
}

function majCommandes(values){
    let commandes = bl.sesCommandes;
    let element = document.querySelector('#commandesbody');
    element.innerHTML = "";
    bl.sesCommandes.forEach(d => {
        let tr = createLineForCommande(d);
        element.appendChild(tr);
    });
}

function createLineForCommande(commande){
    let tr = document.createElement('tr');
    let datas = datasCommandes(commande);
    datas.forEach(d => {
        let td = generateTdWithValue(d);
        tr.appendChild(td);
    });
    let tdbt = document.createElement('td');
    if (commande.EnumEtatCommande == EnumEtatCommande.EnAttente){
        let bts = createButtonForInteractWithCommande(commande);
        bts.forEach(bt => tdbt.appendChild(bt));
        bts[0].addEventListener('click', ()=> { 
            if ( bl.accepterCommande(commande))
                tdbt.innerHTML = "Accepte";         
        });
        bts[1].addEventListener('click', ()=> {
            if ( bl.refuserCommande(commande))
                tdbt.innerHTML = "Refuse";
        });
    } else {
        switch (commande.EnumEtatCommande){
            case EnumEtatCommande.Accepte:
                tdbt.innerHTML = "Commande accepte";
                break;
            case EnumEtatCommande.Refuse:
                tdbt.innerHTML = "Commande refuse";
                break;
            case EnumEtatCommande.Livre:
                tdbt.innerHTML = "Commande livre";
                break;
            case EnumEtatCommande.NonGere:
                tdbt.innerHTML = "Commande non gere";
                break;
            case EnumEtatCommande.NonTenue:
                tdbt.innerHTML = "Commande non tenue";
                break;
        }
    }
    tr.appendChild(tdbt);
    return tr;
}

/**
 * 
 * @param {Commande} commande 
 */
function datasCommandes(commande){
    let datas = [];
    datas.push(commande.numero);
    datas.push(commande.qteDemande);
    datas.push(commande.prixUnitaire);
    datas.push(commande.calculerPrixTotal());
    datas.push(commande.tempsRestant);
    return datas;
}

function createButtonForInteractWithCommande(commande){
    let buttonYes = document.createElement('button');
    buttonYes.innerHTML = "Y";
    let buttonNo = document.createElement('button');
    buttonNo.innerHTML = "N";
    /*buttonYes.addEventListener('click', () => bl.accepterCommande(commande));
    buttonNo.addEventListener('click', ()=> bl.refuserCommande(commande));*/
    return [ buttonYes, buttonNo];
}