class CardCollection{
    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json';
        this.cards = [];
    }

    async load(){
        try{
            let response = await fetch(this.datasource);
            this.cards = await response.json();
            return this.cards;
        } catch(error){

        }
    }

}

export { CardCollection };