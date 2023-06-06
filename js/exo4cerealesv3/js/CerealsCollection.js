import { Cereal } from "./Cereal.js";

class CerealsCollection{
    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/cereals/cereals.json';
        this.datas = [];
    }

    async load(){
        
        let item = localStorage.getItem('savedDatas')
        
        this.datas.result = "success";
        let dataload =  (item != null ? JSON.parse(item) : await this.loadFromDatasource());
        this.datas.data = [];
        if (item != null){    
            dataload.forEach(d=> this.datas.data.push(new Cereal(d)));
        }
        console.log(this.datas);
        return this.datas;
    }

    async loadFromDatasource(){
        try{
            let response = await fetch(this.datasource);
            let dataload = await response.json();
            this.datas.result = dataload.result;
            this.datas.data = [];
            dataload.data.forEach(d=> this.datas.data.push(new Cereal(d)));            
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