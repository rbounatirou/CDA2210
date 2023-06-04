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

    remove(id){
        let idf = this.findIndexOfData(id);
        if (idf >= 0)
            this.datas.data.splice(idf,1);
    }

    findIndexOfData(id){
        return this.datas.data.findIndex(d=> d.id == id);
    }
}

export { CerealsCollection };