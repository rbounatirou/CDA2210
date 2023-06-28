import React from "react";
import './css/cell.css';
import { useState } from "react";


class Cell extends React.Component{

    constructor(props){
        super(props);
        this.state = {colorState: 'E'};
        //console.log("C" + this.props.key);
    }


    render(){
        
        return (
            <div className={this.getClassName()}>
                <div className="couronne"></div>
            </div>
        );
    }

    /* TODO : 
    improve the way to add the class to the cell
    */
    getClassName(){
        let classname = 'cell';
        if (this.state.colorState == 'R'){
            classname += ' red';
        } else if (this.state.colorState == 'Y'){
            classname += ' yellow';
        }
        return classname;
    }

    changeState(_state){
        console.log([this.state, _state]);
        this.setState({colorState: _state});        
        console.log(this.state);
        
    }
}

export default Cell;