import { EmployesCollection } from "./EmployesCollection.js";

const collectionemployes = new EmployesCollection();
collectionemployes.load().then(()=>{
    document.querySelector('#buttontri').addEventListener('click', e => {
            let ascending = e.target.value;
            e.target.value = e.target.value == "true" ? "false" : "true";
            e.target.innerHTML = (e.target.value=="true" ? '^' : 'v');
            
            if (ascending == "true")                
                sortByMonthlySalaryAscending(collectionemployes.employes.data);
            else
                sortByMonthlySalaryDescending(collectionemployes.employes.data);
            refreshValues(collectionemployes.employes.data);
    });
    refreshValues();

});

function refreshValues(){
    let datas = collectionemployes.employes.data;
    let element = document.querySelector('#areatofill');
    element.innerHTML="";
    datas.forEach(d => fillDataOfEmployee(d));
    fillDataOfTotalMonthSalary();
}


function fillDataOfTotalMonthSalary(){
    let datas = collectionemployes.employes.data;
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    
    let td = [];
    for (let i = 0; i < 4; i++){
        td.push(document.createElement('td'));
    }
    td[0].innerHTML = element.childElementCount;
    td[1].colSpan = 2;
    td[2].innerHTML = calcultateTotalSalaryMonth(datas);    
    td[3].colSpan = 2;
    for (let i = 0; i < td.length; i++){
        tr.appendChild(td[i]);
    }
    element.appendChild(tr);
}

function calculateMail(employe){
    let values = employe.employee_name.trim().toLowerCase().split(' ');
    return values[0].charAt(0) + '.' + values[1] + '@email.com';
}

function calculateMonthSalary(employe){
    return Math.round(Number(employe.employee_salary/12.0)*100)/100;
}

function calculateYearOfBirth(employe){
    let date = new Date();
    return date.getFullYear()-Number(employe.employee_age);
}

function calcultateTotalSalaryMonth(datas){
    let sum = 0;
    datas.forEach(d=> sum+= calculateMonthSalary(d));
    return Math.round(sum*100)/100;
}


function fillDataOfEmployee(data){
    let element = document.querySelector('#areatofill');
    let tr = document.createElement('tr');
    let td = [];
    for(let i = 0; i < 6; i++){
        td.push(document.createElement('td'));
    }
    td[0].innerHTML = data.id;
    td[1].innerHTML = data.employee_name;
    td[2].innerHTML = calculateMail(data);
    td[3].innerHTML = calculateMonthSalary(data) + ' €';
    td[4].innerHTML = calculateYearOfBirth(data);
    let buttonDuplicate = document.createElement('button');
    buttonDuplicate.className = "duplicateBt";
    buttonDuplicate.innerText = "🗍 Duplicate"
    buttonDuplicate.type = "button";
    buttonDuplicate.addEventListener('click',()=> {
        btDuplicateFnc(data);
        refreshValues();
        
    });
    let buttonDelete = document.createElement('button');
    buttonDelete.className = 'deleteBt';
    buttonDelete.innerText = '🗑 Delete';
    buttonDelete.type = "button";
    buttonDelete.addEventListener('click',()=> {
        btDeleteFnc(data);
        refreshValues();
        
    });
    td[5].appendChild(buttonDuplicate);
    td[5].appendChild(buttonDelete);
    for (let i = 0; i < td.length; i++){
        tr.appendChild(td[i]);
    }
    element.appendChild(tr);
    

}

function findMaxId(){
    let id = collectionemployes.employes.data[0].id;
    collectionemployes.employes.data.forEach(d => { if (d.id > id){
        id = d.id;
    }});
    return id;
}

function btDeleteFnc(data){
    console.log(collectionemployes.employes.data.length);
    collectionemployes.removeEmploye(data.id);
    console.log(collectionemployes.employes.data.length);
}

function btDuplicateFnc(data){
    let obj = structuredClone(collectionemployes.employes.data.find(d => d.id == data.id));
    
    if (obj != undefined){
        obj.id = findMaxId()+1;
        collectionemployes.employes.data.push(obj);
    }
}

function sortByMonthlySalaryAscending(datas){
    return datas.sort((a,b)=>a.employee_salary-b.employee_salary);
}

function sortByMonthlySalaryDescending(datas){
    return datas.sort((a,b)=>b.employee_salary-a.employee_salary);
}
