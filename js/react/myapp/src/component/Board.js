import React from "react";
import BoardLine from "./BoardLine.js";
import './css/board.css';

class Board extends React.Component{
    static id = 0;
    constructor(props){
        super(props);
        this.boardLines = [];
        this.currentColor = false; // Rouge false , jaune true
        for (let i = 0; i < 7; i++){    
            this.boardLines.push(new BoardLine({key: ++Board.id}));
        }
    }

    render(){
        return (
            <div id="board" >
                {this.boardLines.map((d, i) => <BoardLine key={i} />)}
            </div>
        );
    }

}

export default Board;