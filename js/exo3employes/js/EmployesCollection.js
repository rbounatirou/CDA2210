class EmployesCollection{
    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/employees/employees.json';
        this.employes = [];
    }

    async load(){
        try{
            let response = await fetch(this.datasource);
            this.employes = await response.json();
            return this.employes;
        } catch(error){

        }
    }

    removeEmploye(id){        

        let i = this.findEmployeIndexById(id);
        if (i >= 0)
            delete this.employes.data.splice(i,1);
    }

    findEmployeById(id){
        return this.employes.data.find(d => d.id == id);
    }

    findEmployeIndexById(id){
        return this.employes.data.findIndex(d => d.id == id);
    }
}

export { EmployesCollection };