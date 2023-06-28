import Cell from "./Cell";
import React from "react";
import Board from "./Board";
import './css/boardline.css';

class BoardLine extends React.Component{
    static id = 0;
    constructor(props){
        super(props);
        this.height = 6;
        this.cells = [];
        //console.log("B" + this.props.key);
        for (let i = 0; i < this.height; i++){
            this.cells.push(new Cell({state: 'E', key: ++BoardLine.id  }));
        }

    
        //const [lastIndex,setLastIndex]
        
    }

    getLastEmptyIndex(){
        let lastIndexEmpty = this.cells.length;
        while (lastIndexEmpty > 0 &&  this.cells[lastIndexEmpty-1].state.colorState === 'E'){
            lastIndexEmpty--;            
        }
        return lastIndexEmpty;
    }

    ajouterJeton(_state){

        let index = this.getLastEmptyIndex();
        if (index !== this.cells.length){
            console.log(index);
            this.cells[index].changeState(_state);
            
        }
        
        //console.log(this.cells);
    }
    
    
    render(){
        return (
            <div key="" className="boardline" onClick={()=> this.ajouterJeton('R')} >
                {this.cells.map((d,i)=><Cell key={i} />)}
            </div>
        );
    }
}

export default BoardLine;