// option 2 utiliser l'API Fetch de Javascript

/* 
fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json')
.then(response => response.json())
.then(json => console.log(json));
*/
class Zipcode{

    constructor(){
        this.datasource = 'https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json';
        this.zipcodes = [];
    }

    async load(){
        try{
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            console.log(this.zipcodes);
        } catch(error){
            
        }

    }

    searchByPostalCode(zipcode)
    {
        return this.zipcodes.filter(zip => zip.codePostal == zipcode);
    }

    searchLookLikeCommuneName(cname){
        return this.zipcodes.filter(zip => zip.nomCommune.includes(cname));
    }

    searchByCommuneName(cname)
    {
        return this.zipcodes.filter(zip => zip.nomCommune == cname);
        
    }

    searchLookLikePostalCode(code)
    {
        let results = [];
        let request = this.zipcodes.filter(zip => zip.codePostal.includes(code));
        for(let r of request){
            if (results.filter(res => res.codePostal == r.codePostal).length == 0){
                results.push(r);
            }
        }
        return results;
    }
    
}

export { Zipcode };

/*
function JSPrototype(){

}

JSPrototype.prototype.search = function(){

}*/