import { stringify } from "querystring";
import React from "react";
import styles from './css/cell.module.css'


interface CellStructure{
    colorState : string
}

class Cell extends React.Component{
    constructor(props : any){
        super(props);
        this.state = {colorState: 'E'};
    }

    render(): React.ReactNode {
        return(
            <div>

            </div>
        );
    }

    getClassName(){
        let style : string = styles.cell;
        if (this.state.colorState === 'R'){

        } else if (this.state.colorState === 'Y'){
            
        }
    }

    setColorState(newColor : string){
        this.setState({colorState: newColor});
    }

}
