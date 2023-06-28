import React from "react";
import { useState } from "react";
class CountButton extends React.Component{
    constructor(props){
        super(props);
        this.count = 0;
        this.clickEvent = () => { 
            this.count++;
            this.forceUpdate();
        }
    }

    render(){
        return (
            
            <button onClick={this.clickEvent}>Clicked {this.count} times</button>
        );
    }
}

export default CountButton;