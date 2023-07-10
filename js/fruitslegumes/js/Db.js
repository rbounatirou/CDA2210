class Db{
    static async fetchData(datasource){
        this.data = await fetch(datasource);
        return await this.data.json();
    }
}

export { Db };