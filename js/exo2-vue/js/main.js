import { Cards } from './Cards.js'
import { Card } from './Card.js'

const app = {
    data() {
        return {
            title: "Cardgame",
            cards: null,
            watchedValue: null
        }
    },

    async mounted() {
         /** @var { Cards } cards */
         this.cards = new Cards('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
         this.watchedValue = ['attack', 'armor', 'played', 'victory'];
         await this.cards.getCards();

         console.log(this.cards);

    },

    computed: {
        cardKeys() { return this.cards.getFirst().getKeys(); }
    }

}


Vue.createApp(app).mount("#app");
