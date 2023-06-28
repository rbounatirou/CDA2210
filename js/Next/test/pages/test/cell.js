import React from "react";
import './css/cellstyles.module.css'

class Cell extends React.Component{
    constructor(props){
        super(props);
    }

    render(){
        return(
            <div className={this.getClassName}>
                
            </div>
        )
    }

    getClassName(){
        let cn = "cell";
        if (this.state.colorState === 'R'){
            cn += " red";
        } else if (this.state.colorState === 'Y'){
            cn += " yellow";
        }
        return cn;
    }
}

export default Cell;