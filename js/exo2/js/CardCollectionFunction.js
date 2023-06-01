import {CardCollection} from './CardCollection.js'

const cardCollection = new CardCollection();
await cardCollection.load().then(() => {
    addHeaderInfos(cardCollection.cards[0]);
    cardCollection.cards.forEach(c => addBodyInfo(c));
    addDataAbout(cardCollection.cards);
});

function addHeaderInfos(cardToAdd){
    let element = document.querySelector('#headertofill');
    let keys = Object.keys(cardToAdd);
    let tr = document.createElement('tr');
    tr.id = "headerline"
    for (let k of keys){
        let th = document.createElement('th');
        th.innerHTML += k;
        tr.appendChild(th);
    }
    element.appendChild(tr);
}

function addBodyInfo(cardToAdd){
    let element = document.querySelector('#areatofill');
    let keys = Object.values(cardToAdd);
    let tr = document.createElement('tr');
    for (let k of keys){
        let td = document.createElement('td');
        td.innerHTML += k;
        tr.appendChild(td);
    }
    element.appendChild(tr);
}

function addDataAbout(cards){
    addStrongestAttackCard(cards);
    addStrongestArmorCard(cards);
    addHighestPlayedCard(cards);
    addHighestNumberOfVictoryCard(cards);
}

function addStrongestAttackCard(cards){
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    td.innerHTML =  "Carte avec le plus d'attaque";
    td.className = "precisionline"
    td.colSpan = document.querySelector('#headerline').childElementCount;
    tr.appendChild(td);
    element.appendChild(tr);
    let strongestCard = getStrongestAttackCard(cards);
    addBodyInfo(strongestCard);
}

function addStrongestArmorCard(cards){
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    td.innerHTML =  "Carte avec le plus d'armure";
    td.className = "precisionline"
    td.colSpan = document.querySelector('#headerline').childElementCount;
    tr.appendChild(td);
    element.appendChild(tr);
    let strongestArmorCard = getStrongestArmorCard(cards);
    addBodyInfo(strongestArmorCard);
}

function addHighestNumberOfVictoryCard(cards){
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    td.className = "precisionline"
    td.innerHTML =  "Carte avec le plus de victoires";
    td.colSpan = document.querySelector('#headerline').childElementCount;
    tr.appendChild(td);
    element.appendChild(tr);
    let highestVictoryNumber = getHighestNumberOfVictoryCard(cards);
    addBodyInfo(highestVictoryNumber);
}

function addHighestPlayedCard(cards){
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    let td = document.createElement('td');
    td.className = "precisionline"
    td.innerHTML =  "Carte la plus jouée";
    td.colSpan = document.querySelector('#headerline').childElementCount;
    tr.appendChild(td);
    element.appendChild(tr);
    let highestPlayedCard = getHighestPlayedCard(cards);
    addBodyInfo(highestPlayedCard);
}


function getStrongestAttackCard(cards){
    let bestCard = cards[0];
    cards.forEach(a => {
            if (Number(a.attack) > Number(bestCard.attack)){
                bestCard = a;
            }
    });
    return bestCard;
}

function getStrongestArmorCard(cards){
    let bestCard = cards[0];
    cards.forEach(a => {
            if (Number(a.armor) > Number(bestCard.armor)){
                bestCard = a;
            }
    });
    return bestCard;
}

function getHighestPlayedCard(cards){
    let highestPlayed = cards[0];
    cards.forEach(a=> {
        if (Number(a.played) > Number(highestPlayed.played)){
            highestPlayed = a;
        }
    });
    return highestPlayed;
}

function getHighestNumberOfVictoryCard(cards){
    let highestVictoryNumber = cards[0];
    cards.forEach(a=> {
        if (Number(a.victory) > Number(highestVictoryNumber.victory)){
            highestVictoryNumber = a;
        }
    });
    return highestVictoryNumber;
}