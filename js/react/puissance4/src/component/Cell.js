import React from "react";
import './css/Cell.css';
class Cell extends React.Component
{
    constructor(props){
        super(props);
        this.state = {colorState: (this.props.colorState != undefined ? this.props.colorState : 'E')};
    }

    render(){
        return (<div class={this.getClassName()}>
        </div>
        );
    }

    getClassName(){
        let className = "cell " + this.state.colorState;
        return className;
    }

    changeColorState(newColor){
        this.setState({colorState : newColor});
    }
}

export default Cell;