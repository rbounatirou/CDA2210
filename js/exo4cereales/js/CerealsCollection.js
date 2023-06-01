class CerealsCollection{
    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/cereals/cereals.json';
        this.datas = [];
    }

    async load(){
        try{
            let response = await fetch(this.datasource);
            this.datas = await response.json();
            return this.datas;
        } catch(error){

        }
    }
}

export { CerealsCollection };