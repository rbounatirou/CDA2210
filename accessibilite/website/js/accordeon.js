//onload();


document.querySelector('#imgDesc').addEventListener('click', e=> onClickHide(e.target, document.querySelector('#imgDescDiv'), "Afficher la description de l'image", "Masquer la description de l'image"))

function onClickHide(target, elementToHide, flipText, unFlipText){
    let val = target.dataset.fold;
    // AJOUT DU STYLE ET DES ARIAS POUR MASQUER LE CONTENU
    if (val == 1){
        elementToHide.classList.remove('hiddensection');
        elementToHide.ariaHidden="false";
        target.getAttribute('aria-expanded') = 'false';
    } else {
        elementToHide.classList.add('hiddensection');
        elementToHide.ariaHidden="true";
        target.getAttribute('aria-expanded') = 'false';
    }
    target.dataset.fold = (target.dataset.fold == 1 ? 0 : 1);
    target.innerText = (target.dataset.fold == 0? unFlipText : flipText);
}

function onload(){
    let e = document.querySelector('#codearea');
    e.style.height = e.scrollHeight+"px";
}

