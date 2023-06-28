import React from "react";
import Cell from "./Cell";

class CellLine extends React.Component{
    constructor(props){
        super(props);
        this.clickEvent = () => ajouterJetonCouleur('R');
        this.cells = [];
        for (let i = 0; i < 6; i++){
            this.cells.push(new Cell());
        }
    }

    render(){
        return (
            <div class="cellLine" onClick={this.clickEvent}>
                {this.cells.map(d=>d.render())}
            </div>
        )
    }

    ajouterJetonCouleur(_color){
        console.log(_color);
    }

    findLastIndexAvailable(index){
        let i = 0;
        while (i < this.cells.length && this.cells[i] !='E'){
            
        }
    }
    

}

export default CellLine;