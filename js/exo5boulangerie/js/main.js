import { Boulangerie } from './bakery/Boulangerie.js';
import { EnumEtatCommande } from './bakery/EnumEtatCommande.js';
import { CommandAugmenterNiveau } from './bakery/CommandAugmenterNiveau.js';
import { CommandAugmenterMoulin } from './bakery/CommandAugmenterMoulin.js';
const bl = new Boulangerie();

majIHM();
setInterval( () => {
    bl.doEverySecondJob();
    majIHM();
}, 1000);
/*
// POUR LA SAUVEGARDE A LA FERMETURE
window.onbeforeunload = ()=>bl.sauvegarder();*/


bl.journal.eventChange.push(majLog);
document.querySelector('#openclosebt').addEventListener('click',e=>{
    
    if (bl.estOuverte){
        bl.fermerBoulangerie();
        e.target.innerHTML = "Ouvrir boulangerie";
    } else {
        bl.ouvrirBoulangerie();
        e.target.innerHTML = "Fermer boulangerie";
    }

});



document.querySelector('#sauvegarderbt').addEventListener('click', ()=>{
    bl.sauvegarder()
});

document.querySelector('#redemarrerbt').addEventListener('click', () => {
    localStorage.removeItem('boulangerie');
    window.location.reload();
});


document.querySelector('#btlvupboulangerie').addEventListener('click', e=>{
    bl.journal.executerCommande(new CommandAugmenterNiveau(bl));
        //majLog();
});

document.querySelector('#btlvupmill').addEventListener('click', e=>{
    bl.journal.executerCommande(new CommandAugmenterMoulin(bl));
        //majLog();
});



function majIHM(){
    majHeader();
    majInfos();
    majCommandes();
}

function majLog(){
    let el = document.querySelector('#logbody');
    el.innerHTML = "";
    bl.journal.commands.forEach((d, i) =>  el.innerHTML += d.log() + (i < bl.journal.commands.length ? "<br>" : "" ));
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
    for (let i = 0; i < (10-commandes.length); i++){
        let tr = document.createElement('tr');
        let td = document.createElement('td');
        if (commandes.length > 0)
       
        td.colSpan =  6;
        td.innerHTML = "En attente...";
        tr.appendChild(td);
        element.appendChild(tr);
    }
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
                
                let divContainer = document.createElement('div');
                divContainer.className = 'progressback';
                if (bl.activeCommandes[0].numero == commande.numero){
                    let divProgress = document.createElement('div');
                   
                    divProgress.className = 'progressover';
                    divProgress.style.width =  (Math.round(bl.qteBaguetteStock/commande.qteDemande*100))+'%';
                    divContainer.appendChild(divProgress);
                }
                tdbt.appendChild(divContainer);
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